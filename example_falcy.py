from math import ceil, floor
import random
from re import I

PLAYERS_PER_TABLE = 4
EXTRA_TABLE_PLAYERS = 3
WINNER_POINTS = 2
TIE_POINTS = 1

class Player:
    def __init__(self, name) -> None:
        self.points=0
        self.name=name
        self.playedAgainst=[]
        self.gamesWon=0
        self.gamesPlayed=0
    def addPoints(self, amount):
        self.points+=amount
    def addAdversary(self, enemy):
        self.playedAgainst.append(enemy)
    def addWonGame(self):
        self.gamesWon+=1
    def addPlayedGame(self):
        self.gamesPlayed+=1

class Table:
    def __init__(self, players) -> None:
        self.players=players.copy()
        self.outcome = "INIT"

def selectRandomPlayers(players):
    if len(players)<PLAYERS_PER_TABLE:
        return players
    chosen = random.sample(players, PLAYERS_PER_TABLE)
    for p in chosen:
        players.remove(p)
    return chosen

def displayTables(tables):
    i=0
    for t in tables:
        print("Table ", i+1)
        for player in t.players:
            print("\t",player.name,":", player.points)
        print("\t", t.outcome)
        i+=1

def findPlayerOnTable(table, winner):
    for p in table.players:
        if p.name == winner:
            return p

def selectPlayers(players):
    res = []
    res.append(players[0])
    players.remove(players[0])
    while len(res)<PLAYERS_PER_TABLE:
        i = 0
        adv = players[i]
        if adv in res[-1].playedAgainst:
            i+=1
            adv = players[i]
        res.append(adv)
        players.remove(adv)
    return res

numberOfPlayers = int(input("Inserire numero di giocatori\n"))
rounds = int(input("Inserire numero di round\n"))

counter = 0
players=[]

if int(input("Inserire i nomi a mano? 1 = sì, 0 = no (genera i nomi in automatico) \n"))==1:
    for player in range(numberOfPlayers):
        p = Player(input("Inserire nome giocatore "+str(counter+1)+ "\n"))
        counter += 1
        players.append(p)
else:
    for player in range(numberOfPlayers):
        p = Player(str(counter))
        counter+=1
        players.append(p)

for round in range(rounds):
    #recreate tables and display them
    tables=[]
    backupPlayers = sorted(players.copy(), key=lambda x:x.points, reverse=True)
    numberOfTables = floor(numberOfPlayers/PLAYERS_PER_TABLE)
    for i in range(numberOfTables):
        if round==0:
            t = Table(selectRandomPlayers(backupPlayers))
        else:
            t = Table(selectPlayers(backupPlayers))
        tables.append(t)
    if len(backupPlayers)==EXTRA_TABLE_PLAYERS:
        t = Table(backupPlayers)
        tables.append(t)
        numberOfTables+=1
    else:
        print("Giocatori senza tavolo: ")
        for p in backupPlayers:
            p.addPoints(WINNER_POINTS)
            print(p.name,":", p.points)

    displayTables(tables)
    tablesWithOutcome = 0
    while tablesWithOutcome<numberOfTables:
        target = int(input("Inserire id del tavolo di cui modificare l'esito\n"))
        if tables[target-1].outcome=="INIT":
            tablesWithOutcome+=1
        outcome = int(input("Inserire esito del tavolo "+str( target)+ " (0 vittoria, 1 pareggio)\n"))
        if outcome==0:
            winner = input("Inserire nome del vincitore\n").strip("\n")
            winnerP = findPlayerOnTable(tables[target-1], winner)
            winnerP.addPoints(WINNER_POINTS)
            winnerP.addWonGame()
            tables[target-1].outcome="WIN"

        else:
            for p in tables[target-1].players:
                p.addPoints(TIE_POINTS)
            tables[target-1].outcome="TIE"
        for p in tables[target-1].players:
            p.addPlayedGame()
        
        displayTables(tables)
    

for p in players:
    if p.gamesPlayed==0:
        p.gamesPlayed=-1

players = sorted(players, key=lambda x:(x.points, x.gamesWon/x.gamesPlayed, x.gamesPlayed), reverse=True)
i=0
for p in players:
    print(i+1,".- ", p.name, "\t%vittorie: ", p.gamesWon/p.gamesPlayed*100, "\tpunti: ", p.points)
    i+=1
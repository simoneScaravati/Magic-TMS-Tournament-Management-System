import sys

class Player():

    def __init__( self, name, score = 0 ):
        self.name = name                        # string for player name       
        self.score = score    # numbers of total rounds per game    
    

class Table():

    def __init__(self, players= [], id='table'):
        self.players_list = players     # players must be a list of Player objects
        self.id = id
    
    def __str__(self):
        print(f"Id: {self.id}")
        print(f"Number of Players: {len(self.players_list)}")
        print(f"Players: {self.players_list}")
        return ""
    
class Game():
    
    def __init__(self, number_of_total_rounds = 3, a = 1 ):
        self.table_list = []            # initialize list of Tables objects
        self.total_players = []         # initialize total player numbers   
        self.number_of_total_rounds = number_of_total_rounds # numbers of total rounds per game
        self.actual_round = a           # actual round of the game (?) 
    
    def add_table(self, table):
        self.table_list.append(table)
        
    def remove_table(self, table):
        self.table_list.remove(table)

    # print object override
    def __str__(self):
        print("Game stats: ")
        print(f"Total of tables: {len(self.table_list)}")
        for i in range(len(self.table_list)):
            print(self.table_list[i])
        print(f"Actual round: {self.actual_round}")
        print(f"total players: {self.total_players}")
        print(f"total rounds: {self.number_of_total_rounds}") 
        return ""
        
def print_commands():

    commands_list = {'help': 'print command list',
                    'g': 'print Game actual state', 
                    'add table': 'add a table',
                    't': 'print actual tables status',
                    'add player': 'add player', 
                    'p': 'print player list',

                    }

    print("possible commands: ")
    for k, v in commands_list.items():
        print(f"\t{k}: {v} ")

def add_player():
    print( 'add player!')

def add_table():
    print(  'add table!')



# def process_command(command, arg):
#     dispatch[command](arg)

def process_command(command):
    dispatch = {
        'add player': add_player,
        'add table': add_table,
        'help': print_commands
    }

    f = dispatch[command]
    f()



if __name__ == "__main__":

    print("\n\n\nStarting MAGIC pairing TABLES system\n\n\n")
    
    while (True):
        n = input("Insert numbers of total rounds for the Game >> ")
        if (n.isnumeric()):
            break
        else: 
            print("please insert a number")

    while (True):
        t = input("Insert numbers of total tables >> ")
        if (t.isnumeric()):
            t = int(t)
            break
        else: 
            print("please insert a number")

    game = Game(number_of_total_rounds= int(n))
    
    if(t > 0):
        for i in range(t):
            game.table_list.append(Table())
    
    print(game)
   
    while(True):
        # print_commands()
        c = input("Insert command >> ")
        try:
            process_command(c)
        except Exception as ex:
            print(ex)
            print("command not found")




import sys
from player import *
from table import *
from game import *


commands_list_g = {'help': 'print command list',
                    'g': 'print Game actual state', 
                    'add table': 'add a table',
                    't': 'print actual tables status',
                    'add player': 'add player', 
                    'p': 'print player list',

                    }   
def print_commands(commands_list):

    print("possible commands: ")
    for k, v in commands_list.items():
        print(f"\t{k}: {v} ")

def add_player():
    print( 'add player!')

def add_table():
    print(  'add table!')



# def process_command(command, arg):
#     dispatch[command](arg)

def process_command(command,):
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

    game = Game(number_of_total_rounds= int(n)) #new game
    
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




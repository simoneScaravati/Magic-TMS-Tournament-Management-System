import sys

class Game():
    
    def __init__(self, number_of_total_rounds = 3, actual_round = 1 ):
        self.table_list = []                                    # initialize list of Tables objects
        self.total_players = []                                 # initialize total player numbers   
        self.number_of_total_rounds = number_of_total_rounds    # numbers of total rounds per game
        self.actual_round = actual_round                        # actual round of the game (?) 
    
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
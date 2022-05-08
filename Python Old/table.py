import sys


class Table():

    def __init__(self, players= [], id='table'):
        self.players_list = players     # players must be a list of Player objects
        self.id = id
    
    def __str__(self):
        print(f"Id: {self.id}")
        print(f"Number of Players: {len(self.players_list)}")
        print(f"Players: {self.players_list}")
        return ""
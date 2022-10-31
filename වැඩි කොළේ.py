import random

card={'A':13,'K':12,'Q':11,'J':10,'10':9,'9':8,'8':7,'7':6,'6':5,'5':4,'4':3,'3':2,'2':1}
value_cards=["A","K","Q","J"]
print(ord("A"))
mode=input("chose your mode multiplay mode(mm) or Playing with computer(cm)")
player_name=""
player1=""
player2=""
choices=list()
if mode=="cm":
    player_name=input("Enter your name:")
elif mode=="mm":
    player1=input("Enter the name:")
    player2=input("Enter the name:")


def game_process(p1,p2):
    if mode=="mm":
        if card[p1]>card[p2]:
            return print(f"Winner is {player1}")
        elif(card[p1]==card[p2]):
            return print("Draw")
        else:
            return print(f"Winner is {player2}")
    elif mode=="cm":
        if card[p1]>card[p2]:
            return print(f"Winner is {player_name}")
        elif(card[p1]==card[p2]):
            return print("Draw")
        else:
            return print(f"Winner is computer")

while(True):
    choices = list()
    if mode=="cm":
        computer_value_cards=random.choice(value_cards)
        computer_number_cards=str(random.randrange(2,10))
        choices.append(computer_value_cards)
        choices.append(computer_number_cards)
        computer=random.choice(choices)
        player=input(f"{player_name}- ")
        print(f'{player_name}-{player} and computer-{computer}')
        result = game_process(player, computer)
        print(result)
    elif(mode=="mm"):
        player1_playing = input(f"{player1}- ")
        player2_playing = input(f"{player2}- ")
        print(f'{player1}-{player1_playing} and {player2}-{player2_playing}')
        result = game_process(player1_playing, player2_playing)
        print(result)









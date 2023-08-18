# from turtle import *
# from random import randint
# from time import *

# def razmetka():   #С„СѓРЅРєС†РёСЏ СЂРёСЃСѓРµС‚ СЂР°Р·РјРµС‚РєСѓ РїРѕР»РЅСЏ
#     t=Turtle()
#     t.speed(0)
#     for i in range (1,21):
#         t.penup()
#         t.goto(-200+i*20, 50)
#         t.pendown()
#         t.goto(-200+i*20, -100)
#     t.hideturtle()

# def catch1(x,y):   #СЌС‚Рѕ РѕР±СЂР°Р±РѕС‚С‡РёРє СЃРѕР±С‹С‚РёСЏ РЅР°Р¶Р°С‚РёСЏ РЅР° РїРµСЂРІСѓСЋ С‡РµСЂРµРїР°С€РєСѓ
#   t1.write('Ouch!', font=('Arial', 14, 'normal'))    #РїРёС€РµРј РЅР° СЌРєСЂР°РЅРµ РђСѓС‡
#   t1.fd(randint(10,15))      #С‡РµСЂРµРїР°С€РєР° РґРµР»Р°РµРј СЃР»СѓС‡Р°Р№РЅС‹Р№ С€Р°Рі РѕС‚ 10 РґРѕ 15

# def catch2(x,y):   #СЌС‚Рѕ РѕР±СЂР°Р±РѕС‚С‡РёРє СЃРѕР±С‹С‚РёСЏ РЅР°Р¶Р°С‚РёСЏ РЅР° РїРµСЂРІСѓСЋ С‡РµСЂРµРїР°С€РєСѓ
#   t2.write('РњРЅРµ Р±РѕР»СЊРЅРѕ!', font=('Arial', 14, 'normal'))    #РїРёС€РµРј РЅР° СЌРєСЂР°РЅРµ РђСѓС‡
#   t2.fd(randint(10,15))      #С‡РµСЂРµРїР°С€РєР° РґРµР»Р°РµРј СЃР»СѓС‡Р°Р№РЅС‹Р№ С€Р°Рі РѕС‚ 10 РґРѕ 15

# t1 = Turtle() #С‚СѓС‚ СЂРѕР¶РґР°РµС‚СЃСЏ РЅРѕРІР°СЏ С‡РµСЂРµРїР°С€РєР° РёР· РєР»Р°СЃСЃР° С‡РµСЂРµРїР°С…
# t1.shape("turtle")
# t1.color("red")
# t1.penup()
# t1.goto(-200, 20)
# t1.pendown()
# t1.speed(2)

# t1.onclick(catch1)



# t2 = Turtle() #С‚СѓС‚ СЂРѕР¶РґР°РµС‚СЃСЏ РЅРѕРІР°СЏ С‡РµСЂРµРїР°С€РєР° РёР· РєР»Р°СЃСЃР° С‡РµСЂРµРїР°С…
# t2.shape("turtle")
# t2.color("blue")
# t2.penup()
# t2.goto(-200, -20)
# t2.pendown()
# t2.speed(2)

# t2.onclick(catch2)




# razmetka()

# x_finish = 200
# while t1.xcor() < x_finish and t2.xcor() < x_finish:
#     t1.fd(randint(3,6))
#     t2.fd(randint(3,6))
#     sleep(0.05)

# if t1.xcor() >= x_finish:
#     t1.write("I am the winner")
# else:
#     t2.write("I am the winner")



# exitonclick()

class Dog():
    # name = None
    # poroda = None
    def __init__(self,name,poroda) -> None:
        self.name = name
        self.poroda = poroda

    def fas(self):
        print("Р“Р°РІ-РіР°РІ")

dog_1 = Dog( "Р‘РѕР±РёРє", "РєРѕСЂРіРё" ) 

print(f"{dog_1.name = }, {dog_1.poroda = }")
dog_1.fas()
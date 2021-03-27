#RANDOM PASSWORD GENERATOR
from tkinter import *
import random
from tkinter import messagebox
import pyperclip

def listToString(s):
    string = ""
    return string.join(s);

numbers = ['0','1', '2', '3', '4', '5', '6', '7', '8', '9']
symbols = ['!','@','#','$','%','^','&','*','(',')']
lettersCappital = ['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z']
lettersLower = ['a','b','c','d','e','f','g','h','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']

#Testing
random_CAPLetters = random.sample(lettersCappital, 1)
random_LOWLetters = random.sample(lettersLower, 4)
random_numbers = random.sample(numbers, 4)
random_symbols = random.sample(symbols, 1)
random_CAPLetters = random.sample(lettersCappital, 2)

functionsList = [random_CAPLetters, random_LOWLetters, random_numbers, random_LOWLetters]

first = random.choice(functionsList)
second = random.choice(functionsList)
third = random.choice(functionsList)
fourth = random.choice(functionsList)
fifth = random.choice(functionsList)

password_Generated = first + second + third + fourth + fifth

 #print(listToString(password_Generated))

window = Tk()
window.title("Random Password generator")
window.geometry('350x200')

lbl = Label(window, text="Generate Password")
lbl.grid(column=1, row=0)

passLbl = Label(window, text="************")
passLbl.grid(column=1,row=1)

def clicked():
    random_CAPLetters = random.sample(lettersCappital, 1)
    random_LOWLetters = random.sample(lettersLower, 4)
    random_numbers = random.sample(numbers, 4)
    random_symbols = random.sample(symbols, 1)
    random_CAPLetters = random.sample(lettersCappital, 2)

    functionsList = [random_CAPLetters, random_LOWLetters, random_numbers, random_LOWLetters]

    first = random.choice(functionsList)
    second = random.choice(functionsList)
    third = random.choice(functionsList)
    fourth = random.choice(functionsList)
    fifth = random.choice(functionsList)

    password_Generated = first + second + third + fourth + fifth
    pyperclip.copy(listToString(password_Generated))

    passLbl.configure(text=listToString(password_Generated))
    messagebox.showwarning('PASSWORD', listToString(password_Generated))

button = Button(window, text="START", command=clicked)
button.grid(column=1, row=2)

info = Label(window, text="Password will be copied to clipboard automatically")
info.grid(column=1, row=3)

author = Label(window, text="By Haroldas Varanauskas")
author.grid(column=1, row=4)


window.mainloop()

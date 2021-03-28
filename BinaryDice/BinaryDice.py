#Binary dice by Haroldas Varanauskas 
import random
from tkinter import *

window = Tk()
window.title("Binary Dice")
window.geometry("600x800")

position = [
"""000
010
000""",
"""100
000
001""",
"""100
010
001""",
"""101
000
101""",
"""101
010
101""",
"""101
101
101"""
]

def btn():
    sample = random.choice(position)
    lbl.config(text = sample)

lbl = Label(window, text="""***
***
***""", fg="black", font=("Helvetica", 200))



dice = Button(window, text ="Roll the dice", command=btn)
dice.pack()
lbl.pack()

window.mainloop()

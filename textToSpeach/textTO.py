from tkinter import *
from gtts import gTTS
from playsound import playsound

window = Tk()
window.geometry("350x300")
window.configure(bg="ghost white")
window.title("Text to Speach")

Label(window, text = "TEXT_TO_SPEECH", font = "arial 20 bold", bg='white smoke').pack()
Label(text ="Haroldas Varanauskas", font = 'arial 15 bold', bg ='white smoke' , width = '20').pack(side = 'bottom')
Msg = StringVar()
Label(window,text ="Enter Text", font = 'arial 15 bold', bg ='white smoke').place(x=20,y=60)
entry_field = Entry(window, textvariable = Msg ,width ='50')
entry_field.place(x=20,y=100)

def text_to_speach():
    message = entry_field.get()
    spech = gTTS(text = message)
    spech.save('sound.mp3')
    playsound('sound.mp3')

def exit():
    window.destroy()

def reset():
    Msg.set("")

Button(window, text = "PLAY", font = 'arial 15 bold' , command = text_to_speach ,width = '4').place(x=25,y=140)
Button(window, font = 'arial 15 bold',text = 'EXIT', width = '4' , command = exit, bg = 'OrangeRed1').place(x=100 , y = 140)
Button(window, font = 'arial 15 bold',text = 'RESET', width = '6' , command = reset).place(x=175 , y = 140)

window.mainloop()

input: INP
STA [prezzo]
INP
STA [sconto]
main:LDA [prezzo]
LDB [sconto]
MUL
LDB #100
DIV
STA [przsct]
LDA [prezzo]
LDB [przsct]
SUB
output: OUT
HLT
== Vars ==

prezzo: NOP
sconto: NOP
przsct: NOP

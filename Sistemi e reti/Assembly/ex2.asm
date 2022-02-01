input: INP
STA [prezzo]
main: LDB #50
SUB
JSP [scontouno]
JMP [scontodue]
scontouno: LDA [prezzo]
LDB #10
MUL
LDB #100
DIV
STA [przsct]
LDA [prezzo]
LDB [przsct]
SUB	
JMP [output]
scontodue: LDA [prezzo]
LDB #5
MUL
LDB #100
DIV
STA [przsct]
LDA [prezzo]
LDB [przsct]
SUB
JMP [output]
output: OUT
HLT
== Vars ==
prezzo: NOP
przsct: NOP

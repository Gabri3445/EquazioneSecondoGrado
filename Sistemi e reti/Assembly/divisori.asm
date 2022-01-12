input: 
INP
STA [num]
JIZ [end]
JSP [loop]

loop:

LDA [num]
STA [numDiv]
JSP [divisori]

JMP [loop]

divisori:

LDA [num]
LDB [numDiv]
DIV
STA [divRes]

LDA [numDiv]
LDB [divRes]
MUL
STA [mulRes]

LDA [num]
LDB [mulRes]
SUB
STA [rem]

LDA [numDiv]
STA [outputNum]
LDB #1
SUB
STA [numDiv]
JIZ [input]

LDA [rem]
JIZ [output]

LDA [numDiv]



JMP [divisori]

output:
LDA [outputNum]


OUT



JMP [divisori]

end:

HLT

== VARS ==

num: 	LDA #1
	STA [num]

numDiv: 	NOP

numCount:	NOP

divRes: 	NOP

mulRes:	NOP

rem: 	NOP

outputNum:NOP

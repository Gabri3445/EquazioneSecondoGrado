input: INP
STA [x]
STA [z]
INP
STA [y]
LDB #1
SUB
STA [y]
loop: LDA [x]
LDB [z]
ADD
STA [x]
LDA [y]
LDB #1
SUB
STA [y]
JSP [loop]
output: LDA [x]
OUT
HLT
== Vars ==
x: NOP
y: NOP
z: NOP

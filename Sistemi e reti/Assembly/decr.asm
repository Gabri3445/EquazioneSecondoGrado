input: INP
STA [num]
loop: LDA [num]
JIZ [end]
OUT
LDB #1
SUB
STA  [num]
JMP [loop]
end: HLT
== VARS ==
num: NOP

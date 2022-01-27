input: INP
STA [prezzo]
main: LDB #50
SUB
JSP [scontouno]
JMP [scontodue]

scontouno: LDA [prezzo]

scontodue: LDA [prezzo]

output:

== Vars ==

prezzo: NOP
przsct: NOP

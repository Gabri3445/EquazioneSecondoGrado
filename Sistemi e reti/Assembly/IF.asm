INP
STA 100
LDB #10
SUB
JSN [less]
JMP [more]

less:	LDA 100
	OUT
	HLT

more:	LDA 100
	LDB #5
	SUB
	OUT
	HLT

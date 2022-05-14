from manim import *

class giglo(Scene):
    def construct(self):
        line1 = Line( LEFT*0.2, RIGHT ) 
        line2 = Line( DOWN*0.2, UP ) 
        a= Angle(line1, line2, dot=True, color=YELLOW, dot_color=YELLOW) 
        self.play(Write(VGroup(line1, line2, a), run_time=2))
class Prob:
    def __init__(self, estado):
        self.estado = estado


class No:
    def __init__(self,pai,estado,profundidade):
        self.pai = pai
        self.estado = estado
        self.profunndidade = profundidade



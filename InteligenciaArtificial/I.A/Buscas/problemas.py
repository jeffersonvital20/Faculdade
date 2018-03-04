from Graph import *

class problemas:

    def main(self):
        self.aspiradorDePo()

    def __init__(self):
        print("criou")

    def aspiradorDePo(self):
        Graph.graph.addEdge("ESS", "DSS")
        Graph.graph.addEdge("ESS", "ELS")
        Graph.graph.addEdge("ESS", "ESS")
        Graph.graph.addEdge("DSS", "DSS")
        Graph.graph.addEdge("DSS", "ESS")
        Graph.graph.addEdge("DSS", "DSL")
        Graph.graph.addEdge("ELS", "ELS")
        Graph.graph.addEdge("ELS", "DLS")
        Graph.graph.addEdge("DLS", "DLS")
        Graph.graph.addEdge("DLS", "ELS")
        Graph.graph.addEdge("DLS", "DLL")
        Graph.graph.addEdge("ESL", "ESL")
        Graph.graph.addEdge("ESL", "DSL")
        Graph.graph.addEdge("ESL", "ELL")
        Graph.graph.addEdge("DSL", "DSL")
        Graph.graph.addEdge("DSL", "ESL")
        Graph.graph.addEdge("ELL", "ELL")
        Graph.graph.addEdge("ELL", "DLL")
        Graph.graph.addEdge("DLL", "DLL")
        Graph.graph.addEdge("DLL", "ELL")

        print("Graph")
        print(Graph.graph)

        print("BFS")
        Graph.graph.BFS(Graph.graph.CExplore())

        print("DFS Stack")
        Graph.graph.DFS_Stack(Graph.graph.CExplore())

        print("DFS_Recursive")
        Graph.graph.DFS_Rec(Graph.graph.CExplore())


        estados = []

        estados.append("ESS", "DSS")
        estados.append("ESS", "ELS")
        estados.append("ESS", "ESS")
        estados.append("DSS", "DSS")
        estados.append("DSS", "ESS")
        estados.append("DSS", "DSL")
        estados.append("ELS", "ELS")
        estados.append("ELS", "DLS")
        estados.append("DLS", "DLS")
        estados.append("DLS", "ELS")
        estados.append("DLS", "DLL")
        estados.append("ESL", "ESL")
        estados.append("ESL", "DSL")
        estados.append("ESL", "ELL")
        estados.append("DSL", "DSL")
        estados.append("DSL", "ESL")
        estados.append("ELL", "ELL")
        estados.append("ELL", "DLL")
        estados.append("DLL", "DLL")
        estados.append("DLL", "ELL")

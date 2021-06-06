


vingadores = {"Chris Evans": "Capitão América", "Mark Ruffalo": "Hulk", "Tom Hiddleston": "Loki",
"Chris Hemworth": "Thor", "Robert Downey Jr": "Homem de Ferro", "Scarlett Johansson": "Viúva Negra"}


vingadores["Lou Ferrigno"] = "Hulk das antigas"
vingadores["Jheremy Renner"] = "Gavião Arqueiro"
'''
print(vingadores)
del vingadores["Lou Ferrigno"]
print(vingadores)
print(vingadores.pop("Jheremy Renner", "Ator não econtrado!"))
print(vingadores.popitem())
'''
animais ={"Cachorro": "Spot", "Cavalo": "Pé de Pano", "Gato": "Garfield"}

"""
for i in animais:
    print()
    vingadores[i] = animais[i]

    print(vingadores)
"""

vingadores.update(animais)
print(vingadores)
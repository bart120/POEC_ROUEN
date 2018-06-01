Le jeu de dés
------

# Cahier des charges

On vous demande de développer un jeu sous la forme d'une application console. Il s'agit d'un jeu dans lequel les joueurs lancent des dés : le joueur ayant tiré le dé le plus élevé gagne une manche et augmente son score. L'application garde en mémoire le score de chaque joueur jusqu'à sa fermeture.

##Déroulement du jeu

Après le lancement de l'application, le jeu demande d'abord le nombre de joueurs, puis le nom de chaque joueur.

Ceci fait, il affiche un menu principal similaire à celui-ci :

```
Score actuel :
- Jean : 8 points
- Jeanne : 6 points
- Jacques : 1 point

Choisissez une option :
1 - Nouvelle manche
2 - Voir l'historique des manches
3 - Quitter

Quel est votre choix ? _
```

Le tableau des scores affiche toujours les joueurs triés par score.

## Déroulement d'une manche

Lorsque l'utilisateur sélectionne "Nouvelle manche" dans le menu, on exécute les étapes suivantes :
- Pour chaque joueur, on tire un nombre aléatoire entre 1 et 6
- Si un seul joueur obtient le meilleur tirage, il est crédité de deux points
- Si plusieurs joueurs obtiennent le même meilleur tirage, ils sont crédités de 1 point
- Les autres joueurs ne gagnent pas de points.

Le tirage des joueurs doit être affiché à l'écran.Une fois affichés, on demandera à l'utilisateur d'appuyer sur une touche. Après l'appui sur une touche, on réaffiche le menu principal.

## L'historique des manches

Lorsque l'utilisateur choisit de consulter l'historique des manches, on affiche à l'écran la liste des manches déjà jouées, avec pour chaque :
- La date et l'heure de son déroulement
- Le score de chaque joueur
- Le nombre de points gagnés par chaque joueur. 

Une fois la liste affichée, on demandera à l'utilisateur d'appuyer sur une touche. Une fois la touche appuyée, on retournera au menu principal.

# Etapes de l'exercice

1. En groupe : Conception globale du programme, choix des classes à créer et de leur contenu
2. Individuellement : Implémentation du programme

# Outils techniques utiles

Pour implémenter votre programme, vous aurez peut-être besoin des informations techniques suivantes :
- Pour convertir une chaîne de caractère en nombre (par exemple pour lire le nombre de joueurs), utilisez la méthode statique `Int32.Parse`.
- Pour générer des nombres aléatoires, utilisez les outils disponibles dans la classe `Random`
- Vous pouvez vider le contenu de la console avec `Console.Clear()`. Pour attendre que l'utilisateur appuie sur une touche, vous pouvez utiliser `Console.ReadLine()` ou `Console.ReadKey()`.
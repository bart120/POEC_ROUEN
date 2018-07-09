# BoVoyage - Projet 3

## Objectifs
- Réaliser la base de données sur Azure via code first
- Développer une couche WebAPI avec la norme REST pour l'accès aux données
- Développer une application WEB (html, css, js)
- Créer des requêtes AJAX pour accèder à l'API depuis l'application WEB.
- Travailler en équipe en utilisant GIT

## A faire

* A partir du diagramme UML fourni
  - Créer les les models correspondantes
  - Générer les migrations
  - Mettre à jour la base de données

* Créer les controleurs WEBAPI
    - Un controleur par entitée (model)
    - Penser aux validations métier
    - Respecter le CRUD
    - Pour les recherches, une url du type */api/.../search?...* sera utilisée
    - Votre API devra être documentée

* Créer la partie *FRONT* dans un dossier spécifique
  - Chaque page disposera d'un menu de navigation permettant d'accèder aux autres pages
  - Chaque page aura une fonctionnalité *(ex: créer un client, afficher les clients, créer un voyages...)*
  - Vous pouvez utiliser si vous le désirez les librairies *jQuery* et *Bootstrap*
  - Les erreurs lors de l'enregistrement d'un formulaire devront être gérées également coté client. L'utilisateur sera averti via un message et/ou un changement graphique.

## Critères d'évaluations
Vous serez évalué en binôme, à partir de ce que vous aurez mis à disposition sur votre repository GIT.  
* Class models et migrations (3 points)
    - Les class sont-elles correctes ?
    - Les conventions de nommages sont-elles respectées ?
    - Les relations entre les tables correspondent-elles au diagramme des classes ?
    - Les attributs de validation et type de données sont-ils respectés ?

* WEB API (5 points)
    - La norme REST est-elle respecter ?
    - Les codes retour sont-ils correctes?
    - La gestion des erreurs est-elle en place ?
    - L'API est-elle documentée ?

* App WEB (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les liens et redirections fonctionnent-ils ?
    - Le visuel est-il *propre* et la mise en page responsive design ?
    - Les erreurs de saisie sont-elles gérées?
    - Les balises sont-elles bien utilisées *(pas de mise en page avec un table, input de différent type dans les formulaires, ...)* ?

* Qualité du code *(C#, HTML, CSS, JS)* (3 points)
    - Le code compile-t-il *(C#)*
    - Les conventions de nommage et de codage sont-elles respectées ?
    - Le code est-il lisible *(bon nommage des variables, paramètres et méthodes)* ?
  - Découpage du code en méthodes et bonne disposition des couches
  - Le code est-il optimisé *(utilisation de LINQ, EF, fichier CSS et JS)* ?
  - Le repository GIT est-il bien utilisé ?

* Respect du cahier des charges (4 points)
    - Retrouve-t-on dans l’application les fonctionnalités principales du cahier des charges ?
    - Ces fonctionnalités sont-elles fonctionnelles ?
    - L’application gère-t-elle les validations métier ?

## Aide mémoire

- Conventions de nommage C#  
Pour les noms de classes, méthodes, propriétés, constantes : PascalCase  
Pour les noms de variables, champs, paramètres : camelCase  
Pour les noms des controlers, Nom plurialisé du model  
camelCase = premier mot avec une minuscule puis chaque mot avec une majuscule  
PascalCase = premier mot avec une majuscule puis chaque mot avec une majuscule  

- Conventions de nommage SQL
Les tables ont des noms au pluriel en général  
Pour faire le mapping entre C# et SQL, voici quelques attributs utiles :  
[ForeignKey("nom de la propriété C# qui correspond au champ de la table qui fait la relation ")]  
[Table("nom de la table")]  
[Column("nom du champ dans la table")]  
Pour faire des validations  
[Required(ErrorMessage="message d'erreur")]  
[MaxLenght(ErrorMEssage="message d'erreur")]

- Librairies  
[jQuery](https://jquery.com/)  
[jQueryUI](https://jqueryui.com/)  
[Bootstrap](http://getbootstrap.com/)

- Documentation  
[SWAGGER UI](https://swagger.io/tools/swagger-ui/)  
[MSDN](https://docs.microsoft.com/fr-fr/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api)

- Outils  
[POSTMAN](https://www.getpostman.com/)  
[W3C](https://validator.w3.org/)  

- Docs
[Cahier des charges](https://github.com/bart120/POEC_ROUEN/Projets/BoVoyage-Cahier_des_charges.pdf)  
[Diagramme de classes](https://github.com/bart120/POEC_ROUEN/Projets/Diagramme_classes.pdf)

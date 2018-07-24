# BoVoyage - Projet final

## Objectifs
- Créer le diagramme de class complet
- Réaliser la base de données sur Azure via code first
- Développer une application en ASP.Net MVC 5 (front et back)
- Travailler en équipe en utilisant GIT

## A faire

* A partir du diagramme UML fourni
  - Créer le diagramme UML complet à partie du diagramme initial, des fonctionnalitées ci-dessous et des besoins du cahier des charges
  - Créer les models correspondants
  - Générer les migrations
  - Mettre à jour la base de données

* Créer une application ASP.Net MVC 5
    - Utilisation de la couche MVC
    - Penser aux validations métier coté client et coté serveur
    - Respecter les conventions
    - Créer un code générique si possible
    - Respecter les règles de sécurité vues en formation
    - Créer des zones pour séparer les sous applications
    - Chaque page disposera d'un menu de navigation permettant d'accèder aux autres pages
    - Vous pouvez utiliser si vous le désirez les librairies *jQuery*, *Bootstrap*, *jQuery validation*...

## Fonctionnalités de l'application
Ici est présentée la partie fonctionnelle de l'appication, se référer au cahier des charges pour le reste.
L'application devra être séparée en 3 parties

### Le site web
Accessible directement avec l'url racine "/", cette partie présente les différents voyages actuellement disponible.
On devra avoir accès :
* aux voyages disponibles (destination, prix, dates...)
* une recherche avancée pour trouver des voyages selon les critères suivants (destination, fourchette de prix, fourchette de date de départ)
* Un détail complet pour chaque voyage (infos, photos, ...)  
Dans un soucis de visibilité sur les moteurs de recherche, les urls des voyages seront travaillées avec les données (par exemple, pour le détail d'un voyages "http://localhost/voyages-paris-france/5"
* des pages d'informations diverses (a propos de, ...)
* une page de mise contact ou le client pourra donner ses coordonnées et poser ses questions au service commercial.
* une page de création de compte client

### Le site web (client authentifié) 
Toujours disponible depuis l'url racine "/", cette partie supplémentaire à la partie "site web" permetra au client de pour s'authentifier afin de:
* réserver un voyage et ajouter des participants
* accèder et modifier son profil client
* voir le statut d'une réservation
* avoir l'historique des réservations effectuées

### Le BackOffice (pour les commerciaux)
Disponible depuis l'url suivante "http://localhost/backoffice/", il permettra aux commerciaux de:
* renseigner les données (création/modification/suppression) concernant les voyages (destination, dates, tarifs, place dispo, photos ...)
* Valider ou annuler une réservation.
* Un tableau de bord affichera :
  - Les réservations clients en attente de retour
  - Les voyages disponibles dont le départ est dans mois de 15 jours
* Une page de recherche avancée des voyages
* Une page de recherche avancée des clients
* Une page de détail d'un client
* La possibilité de télécharger au format csv un fichier incluant nom, prénom, mail de tous les clients (pour le mailing)


## Critères d'évaluations
Vous serez évalué en binôme mais la note sera individuelle en fonction du travail fournit dans le bînome, à partir de ce que vous aurez mis à disposition sur votre repository GIT.  
* Class models et migrations (2 points)
    - Les class sont-elles correctes ?
    - Les conventions de nommages sont-elles respectées ?
    - Les relations entre les tables correspondent-elles au diagramme des classes ?
    - Les attributs de validation et type de données sont-ils respectés ?

* Site Web (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les fonctionnalitées sont-elles présentes?
    - La gestion des erreurs est-elle en place ?
    - Le visuel est-il *propre* et la mise en page responsive design ?
    - La recherche est-elle fonctionnelle ?
    - La réécriture d'url est-elle présente ?

* Site Web Client (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les fonctionnalitées sont-elles présentes ?
    - La gestion des erreurs est-elle en place ?
    - Le visuel est-il *propre* et la mise en page responsive design ?
    - L'accès se fait-il bien par une authentification ?
    - Le calcul de prix et la réservation sont-ils fonctionnels ?

* BackOffice (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les fonctionnalitées sont-elles présentes ?
    - La gestion des erreurs est-elle en place ?
    - L'accès se fait-il bien par une authentification ?
    - Les recherches avancés sont-elles fonctionnelles ?

* Respect des conventions (3 points)
    - Les conventions de nommage et de codage sont-elles respectées ?
    - Le code est-il lisible *(bon nommage des variables, paramètres et méthodes)* ?
    - Découpage du code en méthodes et bonne disposition des couches
    - Le code est-il optimisé *(utilisation de LINQ, EF, fichier CSS et JS)* ?
    - Le repository GIT est-il bien utilisé ?


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
[MSDN](https://docs.microsoft.com/fr-fr/aspnet/mvc/overview/getting-started/introduction/getting-started)
[MVC](https://msdn.microsoft.com/fr-fr/library/dd381412(v=vs.108).aspx)

- Outils
[W3C](https://validator.w3.org/)  

- Docs  
[Cahier des charges](https://github.com/bart120/POEC_ROUEN/blob/master/Projets/BoVoyage-Cahier_des_charges.pdf)  
[Diagramme de classes](https://github.com/bart120/POEC_ROUEN/blob/master/Projets/Diagramme_classes.pdf)

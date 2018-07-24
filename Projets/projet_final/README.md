# BoVoyage - Projet final

## Objectifs
- Cr�er le diagramme de class complet
- R�aliser la base de donn�es sur Azure via code first
- D�velopper une application en ASP.Net MVC 5 (front et back)
- Travailler en �quipe en utilisant GIT

## A faire

* A partir du diagramme UML fourni
  - Cr�er le diagramme UML complet � partie du diagramme initial, des fonctionnalit�es ci-dessous et des besoins du cahier des charges
  - Cr�er les models correspondants
  - G�n�rer les migrations
  - Mettre � jour la base de donn�es

* Cr�er une application ASP.Net MVC 5
    - Utilisation de la couche MVC
    - Penser aux validations m�tier cot� client et cot� serveur
    - Respecter les conventions
    - Cr�er un code g�n�rique si possible
    - Respecter les r�gles de s�curit� vues en formation
    - Cr�er des zones pour s�parer les sous applications
    - Chaque page disposera d'un menu de navigation permettant d'acc�der aux autres pages
    - Vous pouvez utiliser si vous le d�sirez les librairies *jQuery*, *Bootstrap*, *jQuery validation*...

## Fonctionnalit�s de l'application
Ici est pr�sent�e la partie fonctionnelle de l'appication, se r�f�rer au cahier des charges pour le reste.
L'application devra �tre s�par�e en 3 parties

### Le site web
Accessible directement avec l'url racine "/", cette partie pr�sente les diff�rents voyages actuellement disponible.
On devra avoir acc�s :
* aux voyages disponibles (destination, prix, dates...)
* une recherche avanc�e pour trouver des voyages selon les crit�res suivants (destination, fourchette de prix, fourchette de date de d�part)
* Un d�tail complet pour chaque voyage (infos, photos, ...)  
Dans un soucis de visibilit� sur les moteurs de recherche, les urls des voyages seront travaill�es avec les donn�es (par exemple, pour le d�tail d'un voyages "http://localhost/voyages-paris-france/5"
* des pages d'informations diverses (a propos de, ...)
* une page de mise contact ou le client pourra donner ses coordonn�es et poser ses questions au service commercial.
* une page de cr�ation de compte client

### Le site web (client authentifi�) 
Toujours disponible depuis l'url racine "/", cette partie suppl�mentaire � la partie "site web" permetra au client de pour s'authentifier afin de:
* r�server un voyage et ajouter des participants
* acc�der et modifier son profil client
* voir le statut d'une r�servation
* avoir l'historique des r�servations effectu�es

### Le BackOffice (pour les commerciaux)
Disponible depuis l'url suivante "http://localhost/backoffice/", il permettra aux commerciaux de:
* renseigner les donn�es (cr�ation/modification/suppression) concernant les voyages (destination, dates, tarifs, place dispo, photos ...)
* Valider ou annuler une r�servation.
* Un tableau de bord affichera :
  - Les r�servations clients en attente de retour
  - Les voyages disponibles dont le d�part est dans mois de 15 jours
* Une page de recherche avanc�e des voyages
* Une page de recherche avanc�e des clients
* Une page de d�tail d'un client
* La possibilit� de t�l�charger au format csv un fichier incluant nom, pr�nom, mail de tous les clients (pour le mailing)


## Crit�res d'�valuations
Vous serez �valu� en bin�me mais la note sera individuelle en fonction du travail fournit dans le b�nome, � partir de ce que vous aurez mis � disposition sur votre repository GIT.  
* Class models et migrations (2 points)
    - Les class sont-elles correctes ?
    - Les conventions de nommages sont-elles respect�es ?
    - Les relations entre les tables correspondent-elles au diagramme des classes ?
    - Les attributs de validation et type de donn�es sont-ils respect�s ?

* Site Web (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les fonctionnalit�es sont-elles pr�sentes?
    - La gestion des erreurs est-elle en place ?
    - Le visuel est-il *propre* et la mise en page responsive design ?
    - La recherche est-elle fonctionnelle ?
    - La r��criture d'url est-elle pr�sente ?

* Site Web Client (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les fonctionnalit�es sont-elles pr�sentes ?
    - La gestion des erreurs est-elle en place ?
    - Le visuel est-il *propre* et la mise en page responsive design ?
    - L'acc�s se fait-il bien par une authentification ?
    - Le calcul de prix et la r�servation sont-ils fonctionnels ?

* BackOffice (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les fonctionnalit�es sont-elles pr�sentes ?
    - La gestion des erreurs est-elle en place ?
    - L'acc�s se fait-il bien par une authentification ?
    - Les recherches avanc�s sont-elles fonctionnelles ?

* Respect des conventions (3 points)
    - Les conventions de nommage et de codage sont-elles respect�es ?
    - Le code est-il lisible *(bon nommage des variables, param�tres et m�thodes)* ?
    - D�coupage du code en m�thodes et bonne disposition des couches
    - Le code est-il optimis� *(utilisation de LINQ, EF, fichier CSS et JS)* ?
    - Le repository GIT est-il bien utilis� ?


## Aide m�moire

- Conventions de nommage C#  
Pour les noms de classes, m�thodes, propri�t�s, constantes : PascalCase  
Pour les noms de variables, champs, param�tres : camelCase  
Pour les noms des controlers, Nom plurialis� du model  
camelCase = premier mot avec une minuscule puis chaque mot avec une majuscule  
PascalCase = premier mot avec une majuscule puis chaque mot avec une majuscule  

- Conventions de nommage SQL
Les tables ont des noms au pluriel en g�n�ral  
Pour faire le mapping entre C# et SQL, voici quelques attributs utiles :  
[ForeignKey("nom de la propri�t� C# qui correspond au champ de la table qui fait la relation ")]  
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

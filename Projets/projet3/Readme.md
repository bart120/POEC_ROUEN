# BoVoyage - Projet 3

## Objectifs
- R�aliser la base de donn�es sur Azure via code first
- D�velopper une couche WebAPI avec la norme REST pour l'acc�s aux donn�es
- D�velopper une application WEB (html, css, js)
- Cr�er des requ�tes AJAX pour acc�der � l'API depuis l'application WEB.
- Travailler en �quipe en utilisant GIT

## A faire

* A partir du diagramme UML fourni
  - Cr�er les les models correspondantes
  - G�n�rer les migrations
  - Mettre � jour la base de donn�es

* Cr�er les controleurs WEBAPI
    - Un controleur par entit�e (model)
    - Penser aux validations m�tier
    - Respecter le CRUD
    - Pour les recherches, une url du type */api/.../search?...* sera utilis�e
    - Votre API devra �tre document�e

* Cr�er la partie *FRONT* dans un dossier sp�cifique
  - Chaque page disposera d'un menu de navigation permettant d'acc�der aux autres pages
  - Chaque page aura une fonctionnalit� *(ex: cr�er un client, afficher les clients, cr�er un voyages...)*
  - Vous pouvez utiliser si vous le d�sirez les librairies *jQuery* et *Bootstrap*
  - Les erreurs lors de l'enregistrement d'un formulaire devront �tre g�r�es �galement cot� client. L'utilisateur sera averti via un message et/ou un changement graphique.

## Crit�res d'�valuations
Vous serez �valu� en bin�me, � partir de ce que vous aurez mis � disposition sur votre repository GIT.  
* Class models et migrations (3 points)
    - Les class sont-elles correctes ?
    - Les conventions de nommages sont-elles respect�es ?
    - Les relations entre les tables correspondent-elles au diagramme des classes ?
    - Les attributs de validation et type de donn�es sont-ils respect�s ?

* WEB API (5 points)
    - La norme REST est-elle respecter ?
    - Les codes retour sont-ils correctes?
    - La gestion des erreurs est-elle en place ?
    - L'API est-elle document�e ?

* App WEB (5 points)
    - Le code est-il valide W3C *(HTML, CSS)* et sans erreur dans la console *(JS)* ?
    - Les liens et redirections fonctionnent-ils ?
    - Le visuel est-il *propre* et la mise en page responsive design ?
    - Les erreurs de saisie sont-elles g�r�es?
    - Les balises sont-elles bien utilis�es *(pas de mise en page avec un table, input de diff�rent type dans les formulaires, ...)* ?

* Qualit� du code *(C#, HTML, CSS, JS)* (3 points)
    - Le code compile-t-il *(C#)*
    - Les conventions de nommage et de codage sont-elles respect�es ?
    - Le code est-il lisible *(bon nommage des variables, param�tres et m�thodes)* ?
  - D�coupage du code en m�thodes et bonne disposition des couches
  - Le code est-il optimis� *(utilisation de LINQ, EF, fichier CSS et JS)* ?
  - Le repository GIT est-il bien utilis� ?

* Respect du cahier des charges (4 points)
    - Retrouve-t-on dans l�application les fonctionnalit�s principales du cahier des charges ?
    - Ces fonctionnalit�s sont-elles fonctionnelles ?
    - L�application g�re-t-elle les validations m�tier ?

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
[SWAGGER UI](https://swagger.io/tools/swagger-ui/)  
[MSDN](https://docs.microsoft.com/fr-fr/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api)

- Outils  
[POSTMAN](https://www.getpostman.com/)  
[W3C](https://validator.w3.org/)  

- Docs
[Cahier des charges](https://github.com/bart120/POEC_ROUEN/Projets/BoVoyage-Cahier_des_charges.pdf)  
[Diagramme de classes](https://github.com/bart120/POEC_ROUEN/Projets/Diagramme_classes.pdf)

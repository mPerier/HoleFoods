# HOLE FOODS

Logiciel de caisse enregistreuse pour Windows

<img src="https://raw.githubusercontent.com/mPerier/HoleFoods/main/HoleFoodsWhiteBG.png" alt="Logo" style="display: block;margin-left: auto;margin-right: auto;width: 30%;">

Repository hébergé sur [GitHub](https://github.com/mPerier/HoleFoods)


### Structure des classes

Explication de l'architecture MVC grâce au diagramme UML:

<img src="https://raw.githubusercontent.com/mPerier/HoleFoods/main/ClassDiagram.png" alt="Diagramme de classe" style="display: block;margin-left: auto;margin-right: auto;">

***A COMPLETER***

### Scénario

Lors du premier lancement de l'application sur une machine, l'application va faire appel à la classe **Chemins** qui va faire apparaitre une succession de popups permettant à l'utilisateur de renseigner :
- Le chemin d'accès au répertoire qui contiendra les tickets
- Le fichier au format *.csv* qui contient la liste des produits et de leur prix

Une fois ces chemins renseignés une première fois, ils seront automatiquement récupérés lors du prochain démarrage de l'application grâce à un fichier de configuration propre à l'utilisateur Windows.

Lorsque l'application à démarré et trouvé ses fichiers, l'utilisateur doit cliquer sur le bouton "Nouveau Panier" pour intialiser un panier et effectuer l'import de la liste de produits.

***A COMPLETER***



### Stockage de paramètres

Les paramètres de l'application sont stockés dans les paramètres utilisateur de Windows: **C:\Users\JohnDoe\AppData\Local\HOLE_FOODS** dans un fichier nommé **user.config**.

Ces paramètres ne sont pas accessibles via le fichier **HOLE FOODS.exe.config** situé dans le dossier de l'executable car c'est le fichier propre à l'application, il transmettrait donc les chemins d'accès de l'utilisateur lors du partage de l'application. Ce fichier de configuration ne peut qu'être lu par l'application.



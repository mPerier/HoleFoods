#Spécificités du logiciel

Variables d'environnement
-------------------------

Le logiciel stocke certains paramètres dans le fichier situé à l'emplacement :

**%LOCALAPPDATA%\\HOLE_FOODS\\HOLE_FOODS.exe_Url_xxx\\1.0.0.0\\user.config**

Dans ce fichier au format *xml* on trouve les paramètres suivants qui sont récupérés à chaque démarrage de l'application :

-   csvFile : Le chemin d'accès complet au fichier contenant la liste des produits au format CSV

-   ticketsPath : Le chemin d'accès au répertoire qui contiendra les tickets générés par l'application

-   numTicket : Le numéro de ticket actuel

Ecriture / Effacement des variables d'environnement
---------------------------------------------------

Certaines variables d'environnement peuvent être mises à jour lors d'évènements tels que la génération d'un nouveau ticket.

SI une des variables d'environnement est introuvable (format incorrect ou fichier introuvable), le logiciel effectuera une des actions suivantes pour obtenir une valeur qu'il réécrira dans le fichier de configuration :

-   Si la variable concerne un chemin d'accès, un explorateur de fichiers permettra à l'utilisateur de le renseigner.

-   Si la variable est un paramètre indépendant du système d'exploitation (le numéro de ticket par exemple), le logiciel lui assignera une valeur par défaut. Par exemple, « numTicket » sera initialisé à 0.

Il est possible de réinitialiser la totalité des variables d'environnement en cliquant sur le bouton « Réinitialiser les paramètres de l'application »


Classes, attributs et méthodes utilisées
----------------------------------------

<img src="https://raw.githubusercontent.com/mPerier/HoleFoods/main/ClassDiagram.png" alt="Diagramme de classes" style="display: block;margin-left: auto;margin-right: auto;">

Répartition des fonctions selon le modèle MVC
---------------------------------------------

Le diagramme suivant récapitule les fonctions et interactions de chacune des classes du logiciel.

<img src="https://raw.githubusercontent.com/mPerier/HoleFoods/main/ClassInterractions.png" alt="Diagramme des interractions entre classes" style="display: block;margin-left: auto;margin-right: auto;">

On remarque que l'élément central du programme est le contrôleur Form1, il a pour rôle de gérer les actions à effectuer pour chaque évènement.

Form1 instancie des classes qui représentent les produits du magasin, et le panier du client :

-   ListeProduits contient la totalité des produits disponibles à l'achat et leurs prix massiques associés. Ils sont extraits d'un fichier source au format CSV.

-   Panier contient la liste des produits achetés par le client.

-   Produit est instancié dans ListeProduits et Panier. Il est représenté par un nom, un prix et une masse.

On retrouve aussi dans Form1 un objet de type Ticket généré en même temps que chaque panier, qui va être utilisé pour bâtir le ticket dans un fichier texte approprié.

Plusieurs classes statiques sont utilisées par une ou plusieurs classes pour interagir simplement avec l'environnement de l'application :

-   AppSettings contient toutes les méthodes utilisées pour lire / écrire dans les variables d'environnement de l'application.

-   FenetresDialogue contient plusieurs méthodes utilisées pour informer l'utilisateur de certains évènements. Elle peut lui demander ou non une information qui sera utilisée pour le traitement de cet évènement.

Enfin, la classe Form1.Designer.cs contient la représentation de la fenêtre principale de l'application.

Diagramme des cas d'utilisation
-------------------------------
<img src="https://raw.githubusercontent.com/mPerier/HoleFoods/main/CaseDiagram.png" alt="Diagramme des cas d'utilisation" style="display: block;margin-left: auto;margin-right: auto;">

Le diagramme suivant résume le déroulement des évènements principaux dans le cas d'utilisation normale ou l'utilisateur démarre l'application, crée un nouveau panier, saisit des produits, et finalement génère le ticket.

D'autres évènements tels que la réinitialisation des paramètres de l'application, l'ouverture du fichier .CSV, ou encore la gestion des exceptions sont de nature très simple. La lecture du code source disponible sur le repository [GitHub](https://github.com/mPerier/HoleFoods) permet de les comprendre aisément.

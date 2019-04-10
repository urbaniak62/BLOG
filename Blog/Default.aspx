<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="header">
        <div class="bannier">
            <h1>Le blog de L'armement</h1>
            <ul class="reseaux">
                <li><a href=""></a><i class="fab fa-facebook-f"></i></a></li>
                <li><a href=""></a><i class="fab fa-twitter"></i></a></li>
                <li><a href=""></a><i class="fab fa-pinterest"></i></a></li>
                <li><a href=""></a><i class="fab fa-instagram"></i></a></li>
                <li><a href=""></a><i class="fas fa-rss"></i></a>
                    
                </li>
            </ul>
        </div>
        <nav class="navbar navbar-expand-lg navbar-light bg-dark" >
            <asp:Label ID="LB_message" runat="server" Text="bienvenu :"></asp:Label>
            <a class="navbar-brand" style="margin-left:35%;"href="#">Accueil</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav ">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Contactez Moi<span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Connection</a>
                    </li>
                    
                </ul>
                <div class="form-inline my-2 my-lg-0">
                    <input class="form-control mr-sm-2" style="border:none;background-color: #343a40;"type="search" placeholder="rechercher" aria-label="Search">
                    <button class="btn btn-outline-success my-2 my-sm-0" style="border:none;color:white;"type="submit"><i class="fas fa-search"></i></button>
                </div>
            </div>
        </nav>
    </div>
    <div class="container1">
        <div class="menu_gauche">
            <div class="row">
                <div class="colCard">
                    <div class="card" style="text-align:center;">
                        <h4 class="qui">Qui suis je</h4>
                        <img src="../Content/image/avatar.jpg" class="avatar" alt="avatar">
                        <div class="card-body">
                            <h5 class="card-title">URBANIAK Nicolas</h5>
                            <p class="card-text">
                                J'ai 40 ans et j'habite dans les Haut de France.
                                Je suis spécialiste dans <strong><a href="#" class="lien">l' armement</a></strong> depuis 2015.
                                J'anime également le blog de de l'armement  depuis 2015.
                            </p>

                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="colCard">
                    <div class="card" style="text-align:center;">

                        <img class="pub" src="../Content/image/pub.jpg" class="avatar" alt="avatar">


                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col" style="max-width:50%;margin-left:50%; ">
                    <div class="card" style="text-align:center;">
                        <h4 class="qui">Categorie</h4>



                        <ul>
                            <li class="lienArme"><a href="">Les Arme de poings</a></li>
                            <li class="lienArme"><a href="">Les fusils d'assaut</a></li>
                            <li class="lienArme"><a href="">Les fusil de precision</a></li>
                        </ul>



                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="liste_article">
            <img src="../Content/image/felin.jpg" alt="felin" class="felin"/>
            <div class="commentaire">
               

            </div>
            <div class="ajouterCommenter">

            </div>

        </div>
    </div>
        <div class="carouselArticle">

        </div>
    
    <div class="footer">

    </div>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
   
</asp:Content>

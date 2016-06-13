<%@ Page Language="C#" masterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WeTripWebApp.HomePage" %>

<asp:Content ID="homePage"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
    
        <%--  
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/SignUp.aspx">SignUp</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/LogIn.aspx">LogIn</asp:LinkButton>
        --%>
        </br>
        </br>
        <%--Carousel--%>

        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
             <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
               
             </ol>

          <!-- Wrapper for slides -->
          <div class="carousel-inner" role="listbox">
            <div class="item active">
              <div class="jumbotron" style="height:350px">
                  <h1 class="text-center" style="color:cornflowerblue">Welcome to WeTrip, the site that helps you meet new travelers.</h1>
                  <p class="text-center"><a class="btn btn-primary btn-lg" href="SignUp.aspx" role="button">Sign Up Now</a></p>
              </div>
            </div>

            <div class="item">
              <div class="jumbotron" style="height:350px">
                  <h1 class="text-center" style="color:darkseagreen">Already have an account? Welcome back. We hope you will have fun.</h1>
                  <p class="text-center"><a class="btn btn-success btn-lg" href="LogIn.aspx" role="button">Log In</a></p>

              </div>
            </div>

          </div>

          <!-- Left and right controls -->
          <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
          </a>
          <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
          </a>
        </div>
        


        <div class="jumbotron">
            <p class="text-center" style="margin:0; font-size:30px">
                Testimonials
            </p>
            <table style="width:100%" class="text-center">
                <tr>
                    <td>
                        <p class="nomargins">Monika-Bla Bla</p>
                    </td>
                    <td>
                        <p class="nomargins">Alex-bla bla</p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p class="nomargins">Lisa-Bla bla</p>
                    </td>
                    <td>
                        <p class="normargins">Adrian-perfect</p>
                    </td>
                </tr>
            </table>
        </div>


    </div>

</asp:Content>
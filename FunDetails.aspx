<%@ Page Title="Fun Ideas Detail" Language="C#" MasterPageFile="~/IsolationM.Master" AutoEventWireup="true" CodeBehind="FunDetails.aspx.cs" Inherits="Assignment1.Net.FunDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPhead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPBody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-12 headingWithimage">
               <div class="image-text">
                   <h1 id="imgCap">Details of the idea</h1>
                   
                   <a class="exploreButton" href="#rowCard" style="background-color: #f14e4e">Explore More</a>
               </div>
            </div>
        </div>
    </div>
    

    <div class="container-fluid">
        <div class="row" id="rowCard">
            
                <asp:Repeater ID="FunIdeaListDetail" runat="server" DataSourceID="SDSFunIdeaDetail" EnableViewState="false">
                        <ItemTemplate>
                            <div class="col-lg-5">
                                <img class="detailImage" src="<%# Eval("nImage") %>" alt="<%# Eval("alternateText") %>" />
                            </div>
                                <div class="col-lg-6">
                                    
                                    <h3 ><%# Eval("ideaID").ToString() +". "+ Eval("title") %> </h3>
                                    <span class="badge badge-pill badge-info"><%# Eval("name") %></span>
                                    <p><%# Eval("description") %></p>
                                </div>
                            
                        </ItemTemplate>
                    </asp:Repeater>      

                <asp:SqlDataSource ID="SDSFunIdeaDetail" runat="server" ConnectionString="<%$ ConnectionStrings:IdeaDBConnectionString %>" 
                    SelectCommand="SELECT Idea.title, Idea.description, Idea.ideaID, Image.alternateText, Image.nImage, Category.name FROM Idea INNER JOIN Category ON Idea.categoryID = Category.categoryID INNER JOIN Image ON Idea.imageID = Image.imageID WHERE ( ideaID= @ideaID)" CancelSelectOnNullParameter="False">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="ideaID" QueryStringField="ideaID" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPScript" runat="server">
</asp:Content>

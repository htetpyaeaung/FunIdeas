﻿<%@ Page Title="Isolation ideas with model binding" Language="C#" MasterPageFile="~/IsolationM.Master" AutoEventWireup="true" CodeBehind="IsolationW2.aspx.cs" Inherits="Assignment1.Net.IsolationW2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPhead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPBody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-12 image-head">
               <div class="image-text">
                   <h1 id="#imgcap">14 fun things to do in isolation time</h1>
                   <h4>By Charles</h4>
                   <a class="exploreButton" href="#greet" style="background-color: #f14e4e">Explore More</a>
               </div>
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <div class="row">
                <div class="col-lg-9 greetbox">
                    <section id="greet">
                        <h2>Greeting to you</h2>
                        
                        <p>Corona virus is threatning every person's lives and the government is forcing us to stay at home.
                           However, just by staying at home makes you feel much uncomfortable and boring. Me either. Thus, i made a list 
                            on what can we do at our home or backyard to kill our boredom. So enjoy my list of 14 different ideas to do while
                            we are on isolation.<span style="font-weight:bold">Happy Qurantine Days!</span>
                        </p>
                    </section>
                </div>
                <div class="col-lg-3 profilebox">
                    <div style="width:100%;height:80%;padding-bottom:45%;position:relative;"><iframe src="https://giphy.com/embed/3otWpBv8l7D9DJKyKk" id="gifID" style="position:absolute" class="giphy-embed"></iframe></div>
                </div>
         </div>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-12">
                <div class="card-columns imagebox">
                    <asp:Repeater ID="SDSFunIdea" runat="server" ItemType="Assignment1.Net.Models.Idea">
                        <ItemTemplate>
                            <div class="card shrink">
                                <img class="card-image-top" src="<%# Item.Image.thumbnail %>" alt="<%# Item.Image.alternateText %>" />
                        
                                <div class="card-body">
                                    <a class="card-title" href="FunDetails.aspx?ideaID=<%# Item.ideaID %>" target="_blank"><%# Item.ideaID +". "+ Item.title %> &nbsp; <span class="badge badge-pill badge-info"><%# Item.Category.name %></span></a>
                                    
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPScript" runat="server">
</asp:Content>

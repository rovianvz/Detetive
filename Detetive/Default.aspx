<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Detetive.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Detetive</title>
    <link rel="stylesheet" href="css/reset.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="screen" />
    
    <script type="text/javascript" src="js/jquery-1.6.min.js"></script>
    <script src="js/cufon-yui.js" type="text/javascript"></script>
    <script src="js/cufon-replace.js" type="text/javascript"></script>
    <script src="js/Open_Sans_400.font.js" type="text/javascript"></script>
    <script src="js/Open_Sans_Light_300.font.js" type="text/javascript"></script> 
    <script src="js/Open_Sans_Semibold_600.font.js" type="text/javascript"></script>  
    
</head>
<body id="page1">
<form id="form1" runat="server">
    <asp:ScriptManager ID="scriptManager1" runat="server" EnablePartialRendering="true"></asp:ScriptManager>
    <div class="bg">
		<div class="main">
			<header>
				<div class="row-1">
					<h1>
						<strong class="slog">Detetive</strong>
					</h1>
				</div>
				<div class="row-2">
					<div class="slider-wrapper">
						<div class="slider">
						 <p>O empresário Bill G. Ates foi assassinado e o corpo dele foi deixado na frente da delegacia de polícia. O detetive Lin Ust Orvalds foi escolhido para investigar este caso. </p> 
                         <p>Após uma série de investigações, ele organizou uma lista com prováveis assassinos, os locais do crime e quais armas poderiam ter sido utilizadas.</p> 
                         <p>Indique quem foi o assassino, o local do crime e a arma usada que com a ajuda de uma testemunha o detetive irá solucionar o caso!</p>
						</div>
					</div>
				</div>
			</header>
    <!-- content -->
            <section id="content">
				<div class="padding">
					<div class="box-bg margin-bot">
						<div class="wrapper">
							<div class="col-1">
								<div class="box first">
									<div class="pad">
										<div class="wrapper indent-bot">
											<div class="extra-wrap">
												<h3 class="color-1">Suspeitos</h3>
											</div>
										</div>
										<div class="wrapper">
											<div class="extra-wrap">
												<asp:ListBox ID="lbSuspects" 
                                                    runat="server" 
                                                    CssClass="listbox"
                                                    SelectionMode="Single"
                                                    Rows="10"  
                                                    CausesValidation="true"/>
                                                <asp:RequiredFieldValidator ID="rfvSuspects" 
                                                    runat="server"          
                                                    ControlToValidate="lbSuspects" /> 
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="col-1">
								<div class="box second">
									<div class="pad">
										<div class="wrapper indent-bot">
											<div class="extra-wrap">
												<h3 class="color-2">Lugares</h3>
											</div>
										</div>
										<div class="wrapper">
											<div class="extra-wrap">
												<asp:ListBox ID="lbPlaces" 
                                                    runat="server" 
                                                    CssClass="listbox"
                                                    SelectionMode="Single"
                                                    Rows="10"
                                                    CausesValidation="true" />
                                                <asp:RequiredFieldValidator ID="rfvPlaces" 
                                                    runat="server"          
                                                    ControlToValidate="lbPlaces" />
											</div>
										</div>
									</div>
								</div>
							</div>
							<div class="col-2">
								<div class="box third">
									<div class="pad">
										<div class="wrapper indent-bot">
											<div class="extra-wrap">
												<h3 class="color-3">Armas</h3>
											</div>
										</div>
										<div class="wrapper">
											<div class="extra-wrap">
												<asp:ListBox ID="lbGuns" runat="server" CssClass="listbox"
                                                    SelectionMode="Single"
                                                    Rows="10"
                                                    CausesValidation="true" />
                                                <asp:RequiredFieldValidator ID="rfvGuns" 
                                                    runat="server"          
                                                    ControlToValidate="lbGuns" />
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
                        <div id="divErrorMessage" style="display:none" class="errorMessage">
                            <asp:Label ID="lblErrorMessage" runat="server">Por favor, selecione um suspeito, um lugar e uma arma.</asp:Label>
                        </div>
                        <div class="center">
                            <asp:Button ID="btnSolucionar" runat="server" Text="Solucionar" OnClick="btnSolucionar_Click" CausesValidation="true" CssClass="button-2" />
                        </div>
                    </div>
					<div class="wrapper">
						<div class="col-3">
							<div class="indent">
								<asp:UpdatePanel ID="upResults" runat="server" UpdateMode="Conditional" >
                                    <ContentTemplate>
                                        <asp:Literal ID="result" runat="server"></asp:Literal>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btnSolucionar" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
							</div>
						</div>
					</div>
				</div>
			</section>
		</div>
	</div>
    <script type="text/javascript"> Cufon.now(); </script>

    <script type="text/javascript">
        function WebForm_OnSubmit() {
            if (typeof (ValidatorOnSubmit) == "function" && ValidatorOnSubmit() == false) {
                if (!$("#divErrorMessage").is(":visible"))
                    $("#divErrorMessage").fadeIn(1000);
                return false;
            } else {
                $("#divErrorMessage").fadeOut(1000);
            }
            return true;
        }
    </script>
</form>
</body>
</html>

        
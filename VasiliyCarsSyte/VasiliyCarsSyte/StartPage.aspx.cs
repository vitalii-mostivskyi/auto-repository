using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VasiliyCarsSyte.Code;
using System.Configuration;
using System.Web.UI.HtmlControls;
using Shop.code;

namespace VasiliyCarsSyte
{
    public partial class StartPage : System.Web.UI.Page
    {
        DataLib Dl = new DataLib(ConfigurationManager.ConnectionStrings["MyconnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                BildCategoryTree();
                Session["iduser"] = Guid.NewGuid();
            }
            if (IsPostBack)
            {
             
                BuildPlaceHolderCars();

            }
        }

        void BildCategoryTree()
        {
            List<Category> categorylist = Dl.getCategory();
            foreach (var value in categorylist)
            {
                TreeNode categoryNode = new TreeNode();
                categoryNode.Text = value.name;
                categoryNode.Value = value.id.ToString();
                TreeViewCaregoryStart.Nodes.Add(categoryNode);
            }

        }

        void BuildPlaceHolderCars()
        {


            if (TreeViewCaregoryStart.SelectedNode != null)
            {
                List<Car> listware = Dl.getCarBelongToCategory(TreeViewCaregoryStart.SelectedNode.Value) ;
                foreach (var value in listware)
                {
                    HtmlGenericControl carDiv = new HtmlGenericControl("div");
                    carDiv.ID = "Car" + value.id;
                    carDiv.Attributes["class"] = "CarDiv";
                    Label labelmark = new Label();
                    Label labelModel = new Label();
                    Label labelcareationdate = new Label();
                    Label labelquintity = new Label();
                    Label labelprice = new Label();
                    Label labelDiscription = new Label();

                    labelmark.ID = "labelmark" + value.id;
                    labelmark.Text = "<b>Mark:</b>"+value.mark+"<br/>";
                    labelModel.ID = "labelModel" + value.id;
                    labelModel.Text = "<b>Model:</b>" + value.model + "<br/>";
                    labelcareationdate.ID = "labelcareationdate" + value.id;
                    labelcareationdate.Text = "<b>CreationDate:</b>" + value.crearoDate + "<br/>";
                    labelquintity.ID = "labelquintity" + value.id;
                    labelquintity.Text = "<b>Quintity:</b>" + value.quantity + "<br/>";
                    labelprice.ID = "labelprice" + value.id;
                    labelprice.Text = "<b>Price:</b>" + value.price.ToString() + "<br/>";
                    labelDiscription.ID = "labelDiscription" + value.id;
                    labelDiscription.Text = "<b>Discription:</b></br>" + value.discription + "<br/>";

                    HtmlGenericControl ButonDiv = new HtmlGenericControl("div");
                    ButonDiv.ID = "buttondiv" + value.id;
                    ButonDiv.Attributes["class"] = "butdiv";
                    LinkButton LinkButtonbuy = new LinkButton();
                    LinkButtonbuy.Text = "Buy";
                    LinkButtonbuy.CommandArgument = value.id.ToString();
                    LinkButtonbuy.Click += new EventHandler(LinkButtonbuyClick);
                    LinkButtonbuy.ID = "LinkButtonbuy" + value.id;
                    ButonDiv.Controls.Add(LinkButtonbuy);

                    carDiv.Controls.Add(labelModel);
                    carDiv.Controls.Add(labelmark);
                    carDiv.Controls.Add(labelcareationdate);
                    carDiv.Controls.Add(labelquintity);
                    carDiv.Controls.Add(labelprice);
                    carDiv.Controls.Add(labelDiscription);
                    carDiv.Controls.Add(ButonDiv);
                    PlaceHolderCars.Controls.Add(carDiv);
                
                }
              
            }
        }
        protected void LinkButtonbuyClick(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            if (!Basket.IsUserExist(Session["iduser"].ToString()))
            {
                Basket.AddUser(Session["iduser"].ToString());
            }

            try
            {
                Basket.AddUserWare(Session["iduser"].ToString(), btn.CommandArgument);
                ShowMessage("Ware added to basket");
            }
            catch (ArgumentOutOfRangeException)
            {
                ShowMessage("you have already bought this product");
                btn.Visible = false;
            }
            btn.Visible = false;
                
        }
        public void ShowMessage(string message)
        {
            string script = "alert(" + '"' + message + '"' + ");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }
    }
}
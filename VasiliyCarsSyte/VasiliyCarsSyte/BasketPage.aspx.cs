using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.code;
using VasiliyCarsSyte.Code;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace VasiliyCarsSyte
{
    public partial class BasketPage : System.Web.UI.Page
    {
        DataLib Dl = new DataLib(ConfigurationManager.ConnectionStrings["MyconnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildPlaceHolderCar();
        }
        void BuildPlaceHolderCar()
        {
          //  List<String> listCarId = new List<string>();
            List<String> listWaresBasket = null;
          //  List<Shop.code.Ware> listware = new List<Shop.code.Ware>();

            listWaresBasket = Basket.GetWaresUser(Session["iduser"].ToString());
            foreach (var values in listWaresBasket)
            {
                Car car = Dl.getCar(values);

                HtmlGenericControl carDiv = new HtmlGenericControl("div");
                carDiv.ID = "Car" + car.id;
                carDiv.Attributes["class"] = "cardiv";
                Label labelmark = new Label();
                Label labelModel = new Label();
                Label labelcareationdate = new Label();
                Label labelquintity = new Label();
                Label labelprice = new Label();
                Label labelDiscription = new Label();
                Label labelCount = new Label();
                TextBox textboxCount = new TextBox();

                textboxCount.ID = "textboxcount" + car.id;
                labelCount.ID = "labelCount" + car.id;
                labelCount.Text = "<b>Count:</b>";

                labelmark.ID = "labelmark" + car.id;
                labelmark.Text = "<b>Mark:</b>" + car.mark + "<br/>";
                labelModel.ID = "labelModel" + car.id;
                labelModel.Text = "<b>Model:</b>" + car.model + "<br/>";
                labelcareationdate.ID = "labelcareationdate" + car.id;
                labelcareationdate.Text = "<b>CreationDate:</b>" + car.crearoDate + "<br/>";
                labelquintity.ID = "labelquintity" + car.id;
                labelquintity.Text = "<b>Quintity:</b>" + car.quantity + "<br/>";
                labelprice.ID = "labelprice" + car.id;
                labelprice.Text = "<b>Price:</b>" + car.price.ToString() + "<br/>";
                labelDiscription.ID = "labelDiscription" + car.id;
                labelDiscription.Text = "<b>Discription:</b></br>" + car.discription + "<br/>";

                HtmlGenericControl ButonDiv = new HtmlGenericControl("div");
                ButonDiv.ID = "buttondiv" + car.id;
                ButonDiv.Attributes["class"] = "butdiv";
                LinkButton LinkButtonbuy = new LinkButton();
                LinkButtonbuy.Text = "delete";
                LinkButtonbuy.CommandArgument = car.id.ToString();
                LinkButtonbuy.Click += new EventHandler(LinkButtonDelClick);
                LinkButtonbuy.ID = "LinkButtonbuy" + car.id;
                ButonDiv.Controls.Add(LinkButtonbuy);

                carDiv.Controls.Add(labelModel);
                carDiv.Controls.Add(labelmark);
                carDiv.Controls.Add(labelcareationdate);
                carDiv.Controls.Add(labelquintity);
                carDiv.Controls.Add(labelprice);
                carDiv.Controls.Add(labelDiscription);
                carDiv.Controls.Add(labelCount);
                carDiv.Controls.Add(textboxCount);
                carDiv.Controls.Add(ButonDiv);
                PlaceHolderCar.Controls.Add(carDiv);
            }
        }
        protected void LinkButtonDelClick(object sender, EventArgs e)
        {
            // Response.Redirect("/StartPage.aspx");
            LinkButton btn = (LinkButton)sender;


            Basket.DeleteUserWare(Session["iduser"].ToString(), btn.CommandArgument);
            btn.Visible = false;


        }

        protected void ButtonBay_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string surname = TextBoxSurname.Text;
            string address = TextBoxAddress.Text;
            string phone = TextBoxPhone.Text;
            Guid idUser = Guid.NewGuid();

            Dl.setNewUser(idUser,name,surname,address,phone);
             foreach (var value in Basket.GetWaresUser(Session["iduser"].ToString()))
            {
               // Car car = Dl.getCar(value);
                TextBox t = (TextBox)PlaceHolderCar.FindControl("textboxcount" + value);
                int count = Convert.ToInt32(t.Text);
                Dl.setOrder(value,count,idUser.ToString());


            }
             Basket.DeleteUser(Session["iduser"].ToString());
             PlaceHolderCar.Visible = false;
             ButtonBay.Visible = false;
            
        }
    }

}
using System;
using Aras.IOM;

namespace External_Input_Example
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            string myTitle = PRTitle.Text;
            string myDescription = PRDesc.Text;
            string mySteps2Rep = PRStepsRepeat.Text;
            if (myTitle == "" || myDescription == "")
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MyAlert", "<script>alert('Please fill in required fields of PR Title and PR Description!!!')</script>");
            else
            {
                String url = url_text.Text;
                String db = db_text.Text;
                String user = user_text.Text;
                String password = password_text.Text;
                HttpServerConnection conn = IomFactory.CreateHttpServerConnection(url, db, user, password);
                Item login_result = conn.Login();
                if (login_result.isError())
                {
                    throw new Exception("Login failed:" + login_result.getErrorDetail());
                }
                Innovator inn = IomFactory.CreateInnovator(conn);
                Item myPR = inn.newItem("PR", "add");
                myPR.setProperty("title", myTitle);
                myPR.setProperty("description", myDescription);
                myPR.setProperty("events", mySteps2Rep);
                myPR.apply();

                conn.Logout();
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MyAlert", "<script>alert('Your PR was created successfully!!!')</script>");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ZadachaTSP
{
    internal class Connection
    {
        OleDbConnection connect;
        OleDbCommand command;

        private void ConnectionTo()
        {
            connect = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\Vsichko_za_uni\3_Kurs\2ri_sem\TSP Proekt\SutdentDormApp\DormsDatabase.accdb");
            command = connect.CreateCommand();
        }

        public Connection()
        {
            ConnectionTo();
        }

        public void InsertArc(Archived arc)
        {
            try
            {
                command.CommandText = "Insert into Archived(DocumentID) values ("
                    + arc.DocumentID;
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void InsertDoc(Renters rent)
        {
            try
            {
                command.CommandText = "Insert into Document(RenterID) values ("
                    + rent.ID;
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void InsertRent(Renters rent)
        {
            try
            {
                command.CommandText = "Insert into Renters(ID,[FullName],EGN,RoomNumber,[FamilyStatus],PhoneNumber,[Type],Payed) values ("
                    + rent.ID + ",'"
                    + rent.FullName + "',"
                    + rent.EGN + ","
                    + rent.RoomNumber + ",'"
                    + rent.FamilyStatus + "',"
                    + rent.PhoneNumber + ",'"
                    + rent.Type + "',"
                    + rent.Payed + ")";
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void UpdateRent(Renters rent)
        {
            try
            {
                command.CommandText = "Update Renters Set Payed='" + true + "'";
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }

        public void UpdateRooms(Rooms rooms)
        {
            try
            {
                command.CommandText = "Update Rooms Set Price=" + rooms.Price + " Where RoomNumber=" + rooms.RoomNumber;
                command.CommandType = CommandType.Text;
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Data");
            }
            finally
            {
                if (connect != null)
                {
                    connect.Close();
                }
            }
        }
    }
}
using System;
using System.Linq;

namespace FileSyncer.Control
{
    sealed class User : ICSVFormat, IListViewRow
    {
        #region Fields
        int? id;
        string userName;
        string passWord;
        string userLevel;
        #endregion

        #region Properties
        public int? Id { 
            get => id;
            private set
            {
                if (id == null)
                {
                    id = value;
                }
                else
                {
                    throw new InvalidOperationException("the DataBase Engine sets the ID");
                }
            } 
        }
        
        public string UserName { 
            get => userName;
            internal set 
            {
                if (Validator.Username(value))
                {
                    userName = value;
                }
                else
                {
                    throw new InvalidOperationException("Invalid username");
                }
            }
        }

        public string PassWord { 
            get => passWord;
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    passWord = value;
                }
            }  
        }
        
        public string UserLevel
        {
            get => userLevel;
            set 
            {
                if (UserLevels.Levels.Contains(value))
                {
                    userLevel = value;
                }

                else
                {
                    userLevel = "viewer";
                }
            } 
        }


        #endregion

        #region Constructors
        public User()
        {
            // Dapper needs it
        }

        public User(string userName, string passWord, string userLevel)
        {
            UserName = userName;
            PassWord = passWord;
            UserLevel = userLevel;
        }
        internal User(int? id, string userName, string passWord, string userLevel) : this(userName, passWord, userLevel)
        {
            Id = id;
        }
        #endregion

        #region Functions, Methods
        public override string ToString()
        {
            return $"{userName}\t{userLevel}";
        }

        public string CSVFormat()
        {
            return $"{id};{userName};{passWord};{userLevel}";
        }
        public string[] ListViewRow()
        {
            string[] array = { id.ToString(), userName, userLevel };
            return array;
        }
        #endregion
    }
}

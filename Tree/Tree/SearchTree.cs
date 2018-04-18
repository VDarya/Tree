using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class SearchTree
    {

        private string value;
        private int count;
        private SearchTree left;
        private SearchTree right;

        
        public void Insert(string value)
        {
            if (this.value == null)
                this.value = value;
            else
            {
                if (this.value.CompareTo(value) == 1)
                {
                    if (left == null)
                    {
                        this.left = new SearchTree();
                    }
                    left.Insert(value);
                }
                else if (this.value.CompareTo(value) == -1)
                {
                    if (right == null)
                    {
                        this.right = new SearchTree();
                    }
                    right.Insert(value);
                }
                else
                {
                    throw new Exception("Узел уже существует");
                }
            }

            this.count = Recount(this);
        }
       
        public SearchTree Search(string value)
        {
            if (this.value == value)
            {
                return this;
            }

            else if (this.value.CompareTo(value) == 1)
            {
                if (left != null)
                {
                    return this.left.Search(value);
                }
                else
                {
                    throw new Exception("Искомого узла в дереве нет");
                }
            }
            else
            {
                if (right != null)
                {
                    return this.right.Search(value);
                }
                else
                {
                    throw new Exception("Искомого узла в дереве нет");
                }
            }
        }
        
        public string Display(SearchTree tree)
        {
            string result = "";
            if (tree.left != null)
            {
                result += Display(tree.left);
            }

            result += tree.value + " ";

            if (tree.right != null)
            {
                result += Display(tree.right);
            }

            return result;
        }
        
        private int Recount(SearchTree tree)
        {
            int count = 0;

            if (tree.left != null)
            {
                count += Recount(tree.left);
            }

            count++;

            if (tree.right != null)
            {
                count += Recount(tree.right);
            }

            return count;
        }
        
        public void Clear()
        {
            this.value = null;
            this.left = null;
            this.right = null;
        }
        
        public bool IsEmpty()
        {
            if (this.value == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

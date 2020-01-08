using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369
{
    public class BinaryTree<TItem> where TItem : IComparable<TItem>
    {
        public BinaryTree(TItem nodeValue)
        {
            this.NodeData = nodeValue;//泛型数据
            this.LeftTree = null;   //左孩子
            this.RightTree = null;   //右孩子
        }

        public void Insert(TItem newItem)    //树的插入操作实现二叉排序树
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinaryTree<TItem>(newItem);

                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinaryTree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }

        }

        //以下执行左中右的遍历方式

        public void WalkTree()   //树的遍历
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.WalkTree();
            }

            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                this.RightTree.WalkTree();
            }
        }


        private TItem NodeData;  //节点
        private BinaryTree<TItem> LeftTree;  //左孩子
        private BinaryTree<TItem> RightTree;  //右孩子
    }
}

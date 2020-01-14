using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369.leetcode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class BBS
    {
        public static TreeNode GeneralNode()
        {
            var node = new TreeNode(1);

            node.left = new TreeNode(2);
            
            node.right = new TreeNode(2);

            node.left.left =  new TreeNode(3);
            node.right.right =  new TreeNode(3);

            node.left.right = new TreeNode(4);
            node.right.left = new TreeNode(4);

            node.left.left.left = new TreeNode(5);
            node.left.left.right = new TreeNode(6);

            node.left.right.left = new TreeNode(7);
            node.left.right.right = new TreeNode(8);

            node.right.left.left = new TreeNode(8);
            node.right.left.right = new TreeNode(7);

            node.right.right.left = new TreeNode(6);
            node.right.right.right = new TreeNode(5);

            return node;
        }

        /// <summary>
        /// 是否是镜像二叉树
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// 这是深度优先遍历了
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<int> GenerateArray(TreeNode node)
        {
            if (node == null) return null;

            var list = new List<int> {node.val};
            if (node.left == null || node.right == null) return list;

            var leftRange = GenerateArray(node.left);
            var rightRange = GenerateArray(node.right);

            list.AddRange(leftRange);
            list.AddRange(rightRange);
            return list;
        }


        /// <summary>
        /// 广度优先遍历
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="rsInts"></param>
        public static void GeneralBBSarr(List<TreeNode> nodes,ref List<int> rsInts)
        {
            if (nodes.Count == 0) return;

            var listNodes = new List<TreeNode>();
            for (var i = 0; i < nodes.Count; i++)
            {
                rsInts.Add(nodes[i].val);
                if (nodes[i].left != null && nodes[i].right != null)
                {
                    listNodes.Add(nodes[i].left);
                    listNodes.Add(nodes[i].right);
                }
            }
            GeneralBBSarr(listNodes,ref rsInts);
        }

        /// <summary>
        /// 直接判断是否是镜像对称
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="rsInts"></param>
        public static bool GeneralBBSarrCritical(List<TreeNode> nodes)
        {
            if (nodes.All(node=>node==null)) return true;

            var listNodes = new List<TreeNode>();

            var count = nodes.Count;
            for (var i = 0; i < count; i++)
            {
                if (i < count / 2 && nodes[i]?.val != nodes[count - i - 1]?.val)
                {
                    return false;
                }
                listNodes.Add(nodes[i]?.left);
                listNodes.Add(nodes[i]?.right);
            }
            return GeneralBBSarrCritical(listNodes);
        }
    }
}

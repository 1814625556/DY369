﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY369
{
    public class AdjacencyList<T>
    {
        List<Vertex<T>> items; //图的顶点集合
        public AdjacencyList() : this(10) { } //构造方法
        public AdjacencyList(int capacity) //指定容量的构造方法
        {
            items = new List<Vertex<T>>(capacity);
        }
        public void AddVertex(T item) //添加一个顶点
        {   //不允许插入重复值
            if (Contains(item))
            {
                throw new ArgumentException("插入了重复顶点！");
            }
            items.Add(new Vertex<T>(item));
        }
        public void AddEdge(T from, T to) //添加无向边
        {
            Vertex<T> fromVer = Find(from); //找到起始顶点
            if (fromVer == null)
            {
                throw new ArgumentException("头顶点并不存在！");
            }
            Vertex<T> toVer = Find(to); //找到结束顶点
            if (toVer == null)
            {
                throw new ArgumentException("尾顶点并不存在！");
            }
            //无向边的两个顶点都需记录边信息
            AddDirectedEdge(fromVer, toVer);
            AddDirectedEdge(toVer, fromVer);
        }
        public bool Contains(T item) //查找图中是否包含某项
        {
            foreach (Vertex<T> v in items)
            {
                if (v.data.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        private Vertex<T> Find(T item) //查找指定项并返回
        {
            foreach (Vertex<T> v in items)
            {
                if (v.data.Equals(item))
                {
                    return v;
                }
            }
            return null;
        }
        //添加有向边
        private void AddDirectedEdge(Vertex<T> fromVer, Vertex<T> toVer)
        {
            if (fromVer.firstEdge == null) //无邻接点时
            {
                fromVer.firstEdge = new Node(toVer);
            }
            else
            {
                Node tmp, node = fromVer.firstEdge;
                do
                {   //检查是否添加了重复边
                    if (node.adjvex.data.Equals(toVer.data))
                    {
                        throw new ArgumentException("添加了重复的边！");
                    }
                    tmp = node;
                    node = node.next;
                } while (node != null);
                tmp.next = new Node(toVer); //添加到链表未尾
            }
        }
        public override string ToString() //仅用于测试
        {   //打印每个节点和它的邻接点
            string s = string.Empty;
            foreach (Vertex<T> v in items)
            {
                s += v.data.ToString() + ":";
                if (v.firstEdge != null)
                {
                    Node tmp = v.firstEdge;
                    while (tmp != null)
                    {
                        s += tmp.adjvex.data.ToString();
                        tmp = tmp.next;
                    }
                }
                s += "\r\n";
            }
            return s;
        }
        //嵌套类，表示链表中的表结点
        public class Node
        {
            public Vertex<T> adjvex; //邻接点域
            public Node next; //下一个邻接点指针域
            public Node(Vertex<T> value)
            {
                adjvex = value;
            }
        }
        //嵌套类，表示存放于数组中的表头结点
        public class Vertex<TValue>
        {
            public TValue data; //数据
            public Node firstEdge; //邻接点链表头指针
            public Boolean visited; //访问标志,遍历时使用
            public Vertex(TValue value) //构造方法
            {
                data = value;
            }
        }
    }

}

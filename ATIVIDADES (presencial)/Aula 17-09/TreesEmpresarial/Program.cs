using Trees;

Tree<int> tree = new Tree<int>();

tree.Root = new TreeNodes<int>();

tree.Root.Data = 100;

tree.Root.Children =
    new List<TreeNodes<int>>
    {
        new TreeNodes<int>() { Data = 50,Parent = tree.Root }, //0
        new TreeNodes<int>() { Data = 1,Parent = tree.Root }, //1
        new TreeNodes<int>() { Data = 150,Parent = tree.Root } //2

    };


tree.Root.Children[2].Children =
    new List<TreeNodes<int>>
    {
        new TreeNodes<int>() { Data = 30, Parent = tree.Root.Children[2] }
    };
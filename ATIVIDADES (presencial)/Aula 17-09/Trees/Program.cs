using Trees;
// Declaração de variavel tree do tipo Tree
// Onde Tree<int> agora é de inteiros

Tree<int> tree = new Tree<int>();

// Root é o nó raiz da árvore
// instanciado com seu tipo TreeNodes
// onde TreeNodes<int> é do tipo inteiro

// Instanciando o nó raiz
tree.Root = new TreeNodes<int>();

// Atribuindo o valor do nó raiz
tree.Root.Data = 100;

// Atribuindo os filhos do nó raiz
tree.Root.Children =
    new List<TreeNodes<int>>
    {
        new TreeNodes<int>() { Data = 50,Parent = tree.Root }, //0
        new TreeNodes<int>() { Data = 1,Parent = tree.Root }, //1
        new TreeNodes<int>() { Data = 150,Parent = tree.Root } //2

    };

// Atribuindo o filho do nó 150
// 30 é uma folha, pois não possui filhos

tree.Root.Children[2].Children =
    new List<TreeNodes<int>>
    {
        new TreeNodes<int>() { Data = 30, Parent = tree.Root.Children[2] }
    };

namespace Trees
{
    // T -> O Tsão é a especificação do tipo genérico (Generics)
    public class TreeNodes<T>

    {

        // O atributo Data é do tipo T generic
        // Armazenará o valor de fato
        // O ? indica que o valor pode ser nulo (Nullable)
        public T? Data { get; set; }

        // O atributo Parent será a referência para o nó pai
        public TreeNodes<T>? Parent { get; set; }

        // O atributo Children será a lista de nós filhos
        // Também do tipo T generic
        public List<TreeNodes<T>>? Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            TreeNodes<T>? current = this;
            
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}
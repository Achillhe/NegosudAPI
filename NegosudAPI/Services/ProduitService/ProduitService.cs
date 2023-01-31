namespace NegosudAPI.Services.ProduitService
{
    public class ProduitService : IProduitService
    {
        private readonly DataContext _context;

        public ProduitService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Produit>> AddProduct(Produit produit)
        {
            _context.Produits.Add(produit);
            await _context.SaveChangesAsync();
            return await _context.Produits.ToListAsync();
        }

        public async Task<List<Produit>?> DeleteProduct(int Id)
        {
            var produit = await _context.Produits.FindAsync(Id); ;
            if (produit is null)
                return null;

            _context.Produits.Remove(produit);
            await _context.SaveChangesAsync();
            return await _context.Produits.ToListAsync();
        }

        public async Task<List<Produit>> GetAllProducts()
        {
            var produits = await _context.Produits.ToListAsync();
            return produits;
        }

        public async Task<Produit?> GetSingleProduct(int Id)
        {
            var produit = await _context.Produits.FindAsync(Id);
            if (produit is null)
                return null;

            return produit;
        }

        public async Task<List<Produit>?> UpdateProduct(int Id, Produit request)
        {
            var produit = await _context.Produits.FindAsync(Id);
            if (produit is null)
                return null;

            produit.nom_de_domaine = request.nom_de_domaine;
            produit.type = request.type;
            produit.reference = request.reference;
            produit.quantite = request.quantite;
            produit.prix = request.prix;
            produit.volume = request.volume;
            produit.millesime = request.millesime;

            await _context.SaveChangesAsync();

            return await _context.Produits.ToListAsync();
        }
    }
}

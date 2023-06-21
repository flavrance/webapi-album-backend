namespace AlbumApp.Domain.Tasks
{
    using AlbumApp.Domain.Albuns;
    using AlbumApp.Domain.ValueObjects;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public sealed class FaixaCollection
    {
        private readonly IList<Faixa> _faixas;


        public FaixaCollection()
        {
            _faixas = new List<Faixa>();
        }

        public IReadOnlyCollection<Faixa> GetFaixas()
        {
            IReadOnlyCollection<Faixa> albuns = new ReadOnlyCollection<Faixa>(_faixas);
            return albuns;
        }
        public Faixa GetUltimaFaixa()
        {
            Faixa faixa = _faixas[_faixas.Count - 1];
            return faixa;
        }

        public void Add(Faixa faixa)
        {
            _faixas.Add(faixa);
        }

        public void Add(IEnumerable<Faixa> faixas)
        {
            foreach (var faixa in faixas)
            {
                Add(faixa);
            }
        }               
    }
}

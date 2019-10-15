using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    // 1 - Usar nossa pasta model
    // 2 - Criar uma instancia nova da nossa COntext

    //Primeiro deixamos a nossa classe publica
    public class CelularesController
    {
        CelularesContextDB contextDB = new CelularesContextDB();
        //Listagem
        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativos apenas
        /// </summary>
        /// <returns>QuesryList de celulare filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB //Nosso acesso ao banco de dados
                .Celulares // Nossa tabela do banco de dados
                .Where(x => x.Ativo == true); //as condições do filtro
        }
        //Atualização
        /// <summary>
        /// Metodo que atualiza um registro valido no nossos sistema
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Query de celulares filtrado por ativo</returns>
        public bool AtualizarCelular(Celular item)
        {
            var Celular = //Definimos uma variavel para o celular
                contextDB //Usamos o banco de dados
                .Celulares //Nossa tabela que tem os celulares
                .FirstOrDefault //Buscamos em nossa tabela o celular
                (x => x.Id == item.Id); //Regra para realizar a busca

            //Falamos que nossa celular da tabela vai ser igual
            //Nosso celular que estamos passando
            if (Celular == null) //verificamos se ele realmente encontrou um celular
                return false; //Caso não tenha encontrado retornamos falso
            else
            {                
                Celular.DatAlteracao = DateTime.Now; //atualizamos a data alteracao do nosso celular
            }
            
            contextDB.SaveChanges(); //Salvamos a informação no banco

            return true; //retornanmos que foi atualizado
        }
        //Inserção
        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna verdadeiro para um item valido </returns>
        public bool InserirCelular (Celular item)
        {
            if (string  //Nosso tipo que contem varios metodos prontos parastring
                .IsNullOrWhiteSpace //Metodo que identi. espaços em branco apenas ou Valor null
                (item.Marca)) //Nosso campo que vamos validar
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Preco <= 0) //Verificamos se o valor informado é maior que 0
                return false;  //Caso não, ele ja retorna para fora do metodo

            contextDB.Celulares.Add(item); //Salvamos nosso item dentro de nossa tabela em memoria
            contextDB.SaveChanges(); //Salvamos agora no banco de dados esta informação
            return true; //Retornanos verdadeiro para indicar sucesso na inserção do registro
        } 
        //'Remoção'
        /// <summary>
        /// Metodo utilizado para apenas desativar o item dentro do nosso tema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular = //Nossa variavel
                contextDB //Nossa tabela de celular
                .Celulares //Tabela de celular
                .FirstOrDefault //Buscamos o item para desativar
                (x => x.Id == id); //Informamos a regra de busca por Id

            if (celular == null) //Verificamos se este item existe
                return false; //Caso não ele sai de nosso metodo

            celular.Ativo = false; //Desativamos o item

            contextDB.SaveChanges(); //Salvamos em nosso baanco

            return true; //Retornamos verdadeiro
        } 
    }
}

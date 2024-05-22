
//Polymorphism
car newCar = new car();
bus newBus = new bus();

List<Vehicle> vehicleList = new List<Vehicle>();

vehicleList.Add(newCar);
vehicleList.Add(newBus);

//Abstraction,
interface IVehicle {
    void run();
}

//Inheritance

public abstract class Vehicle   {
    // Encapsulation
    public string name;
    public abstract void run();
}


public class car : Vehicle
{
    private decimal price;
    public decimal fuel;
    public override void run()
    {
        throw new NotImplementedException();
    }
}
public class bus : Vehicle
{
    public override void run()
    {
        throw new NotImplementedException();
    }
}

public class impThread {
    public void criarThread(){
        Thread thread = new Thread(() => {
            Console.WriteLine("Dentro da thread");
        });

        var contas = Task.Factory.StartNew(() => {
            Console.WriteLine("Dentro da TASK");
        });

        Task.WaitAll(contas); //Espera todas as tasks terminarem

    }
}


public class Coleções {


    public void exArray(){
        string[] aulas = new string[3];
        aulas[0] = "a";
        for (int i = 0; i < aulas.Length; i++)
        {
            Console.WriteLine(aulas[i]);
        }
         // Array.Reverse Reverte o array
         // Array.Sort Ordena o array
         // Array.Clear Limpa o array
         // Array.IndexOf Retorna o índice do elemento
         // Array.LastIndexOf Retorna o último índice do elemento
         // Array.Find Retorna o primeiro elemento que satisfaz a condição
         // Array.FindAll Retorna todos os elementos que satisfaz a condição
         // Array.TrueForAll Retorna se todos os elementos satisfaz a condição
         // Array.ForEach Executa uma ação para cada elemento do array
         // Array.Resize Aumenta ou diminui o tamanho do array
         // Array.Copy Copia um array para outro array
         // Array.Empty Retorna um array vazio
         // Array.IndexOf Retorna o índice do primeiro elemento que satisfaz a condiçãO

    }


    public void exLista(){
        List<string> aulas = new List<string>();
        aulas.Add("a");
        aulas.Add("b");
        aulas.Add("c");
        for (int i = 0; i < aulas.Count; i++)
        {
            
            Console.WriteLine(aulas[i]);
        }
        
        // List.Add Adiciona um elemento no final da lista
        // List.AddRange Adiciona uma lista no final da lista
        // List.Clear Limpa a lista
        // List.Contains Verifica se o elemento está na lista
        // List.IndexOf Retorna o índice do primeiro elemento que satisfaz a condição
        // List.LastIndexOf Retorna o último índice do elemento
        // List.Find Retorna o primeiro elemento que satisfaz a condição
        // List.FindAll Retorna todos os elementos que satisfaz a condição
        // List.Remove Remove o primeiro elemento que satisfaz a condição
        // List.RemoveAll Remove todos os elementos que satisfaz a condição
        // List.TrueForAll Retorna se todos os elementos satisfaz a condição
        // List.ForEach Executa uma ação para cada elemento da lista
        // List.Sort Ordena a lista
        // List.Reverse Reverte a lista
        // List.Insert Insere um elemento em uma posição específica
        // List.InsertRange Insere uma lista em uma posição específica
        // List.RemoveRange Remove uma lista em uma posição específica
        // List.BinarySearch Retorna o índice do primeiro elemento que satisfaz a condição
        // List.IndexOfArray Retorna o índice do primeiro elemento que satisfaz a condição
        // List.LastIndexOfArray Retorna o último índice do elemento
        
        //ReadOnlyCollection retorna uma lista somente de leitura





    }


    public void exSet(){ //set = Conjuntos
        //Propriedades do Set
            //# 1. Não permite duplicidade
            //# 2. os elementos não são mantidos em ordem específica
        ISet<string> alunos = new HashSet<string>();
        alunos.Add("a");
        alunos.Add("b");
        alunos.Add("c");

        //# A principal diferença entre o Set e a list é que o Set utiliza a tabela de espalhamento
        // para encontrar os elementos, já a lista roda toda a colueção
        // # Por isso ele gasta mais memória que a lista, porém é mais escalavel e performático


    }


    public void exDictionary(){
        Dictionary<string,string> alunos = new Dictionary<string, string>();
        alunos.Add("a","1");
        alunos.Add("b", "2");
        alunos.Add("c", "3");

    }


    public void managerMemory(){
        List<Guid> chavesAcesso = new List<Guid>();
        //O tempo para realizar essa operação é muito alto, pois terá que realocar todos os elementos que estão após o primeiro indice para inserir um novo
        chavesAcesso.Add(Guid.NewGuid());
        for (int i = 0; i < 100000; i++)
        {
            chavesAcesso.Insert(1,Guid.NewGuid());
        } 

        //Como arrumar?
        //O LinkedList é mais lento em relação a listas quando faz a inserção no fim ou no inicio
        // Porém, quando é preciso realocar elementos ( como inserção no meio da lista) a linked list é extremamente mais rápida
        LinkedList<Guid> chavesAcessoRef = new LinkedList<Guid>();
        chavesAcessoRef.AddFirst(Guid.NewGuid());
        for (int i = 0; i < 100000; i++)
        {
            chavesAcessoRef.AddAfter(chavesAcessoRef.First,Guid.NewGuid());
        }

 


    }


}



//NO C# A funcionalidade de THREAD é responsável por realizar o paralelismo de processamento de dados
/*
- PARA CRIAR THREADS:
    Thread newThread = new Thread(() => { .... }));


    newThread.Start();



    //VERIFICA SE A THREAD ESTA EM EXECUÇÃO POR MEIO DO METÓDO ISALIVE


    //COLOCAR A THREAD PARA NÃO FAZER NADA COM O METÓDO SLEEP 



    //A implementação de threads pode ser muito demorada e dificil de ser feita, já que é preciso
    alterar diversos lugares para fazer esse processamento. Então, ao invés de criar uma nova thread e 
    delegar um papel para ela, é possivel criar a tarefa e por meio de um gestor de tarefas atribuir essa
    as threads que o computador possui

    // O TaskSchedule é o gestor das tarefas que é utilizado de forma padrão quando usado o Task.Factory
    // O Task é a própria task que é criada com Task.Factory
    // WhenAll - Utilizado para criar uma thread paralela só para aguardar outras tarefas
    // ContinueWith - Criar uma tarefa após outra ser executada


    // O Async e Await facilita toda o retorno da task, pois não é preciso tratar o retorno da task
    o próprio await faz tal feito


    // O que o Async e o Await faz é basicamente encadear uma nova task com o código que está depois do await sobre o resultado da função. 
    Assim, o código não aguarda o await finalizar , ele só chama a nova task para com o código posterior a ser executado.
*/
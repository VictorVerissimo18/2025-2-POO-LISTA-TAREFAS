// tarefas.cs

using System;

public class Tarefas
{
    public int id { get; set; }
    public string nome { get; set; }
    public string descricao { get; set; }
    public DateTime dataCriacao { get; set; }
    public int status { get; set; }
    public DateTime dataExecucao { get; set; }

    // Construtor padrão
    public Tarefas()
    {
        // Inicializa a data de criação e o status
        this.dataCriacao = DateTime.Now;
        this.status = 0; // Ex: 0 = Pendente
    }

    // Construtor para inicializar as propriedades principais
    public Tarefas(int id, string nome, string descricao)
    {
        this.id = id;
        this.nome = nome;
        this.descricao = descricao;
        this.dataCriacao = DateTime.Now;
        this.status = 0;
    }
}

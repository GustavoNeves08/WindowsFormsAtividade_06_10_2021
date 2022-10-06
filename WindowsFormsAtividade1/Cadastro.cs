public class Cadastro
{
    private string cpf;
    private string email;
    private string senha;
    private Informacoes infos;

    public Cadastro()
    {
        this.cpf = "";
        this.email = "";
        this.senha = "";
        this.infos = new Informacoes();
    }

    public Cadastro(string p_cpf, string p_email, string p_senha, string p_consentimento1, string p_consentimento2, string p_politicas_priv, string p_termos) 
    {
        this.cpf = p_cpf;
        this.email = p_email;
        this.senha = p_senha;
    }

    public string getcpf() { return cpf; }
    public void setcpf(string p_cpf) { this.cpf = p_cpf; }

    public string getemail() { return email; }
    public void setemail(string p_email) { this.email = p_email; }

    public string getsenha() { return senha; }
    public void setsenha(string p_senha) { this.senha = p_senha; }

    public string getnome()
    {
        return this.infos.nome;
    }
    public void setnome(string p_nome)
    {
        this.infos.nome = p_nome;
    }

    public string getsobrenome()
    {
        return this.infos.sobrenome;
    }
    public void setsobrenome(string p_sobrenome)
    {
        this.infos.sobrenome = p_sobrenome;
    }

    public string getpais()
    {
        return this.infos.pais;
    }
    public void setpais(string p_pais)
    {
        this.infos.pais = p_pais;
    }

    public string getmes()
    {
        return this.infos.mes;
    }
    public void setmes(string p_mes)
    {
        this.infos.mes = p_mes;
    }

    public int getano()
    {
        return this.infos.ano;
    }
    public void setano(int p_ano)
    {
        this.infos.ano = p_ano;
    }

    public string getsexo()
    {
        return this.infos.sexo;
    }
    public void setsexo(string p_sexo)
    {
        this.infos.sexo = p_sexo;
    }
}


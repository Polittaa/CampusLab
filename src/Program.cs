bool usuarioAtivo = true; 
int quantidadeEmprestimos = 1;
bool possuiAtraso = false;
bool equipamentoDisponivel = true;


Console.WriteLine("=== CampusLab ===");
Console.WriteLine("Usuário ativo: " + usuarioAtivo);
Console.WriteLine("Empréstimos simultâneos: " + quantidadeEmprestimos);
Console.WriteLine("Possui atraso: " + possuiAtraso);
Console.WriteLine("Equipamento disponível: " + equipamentoDisponivel);


if (usuarioAtivo && quantidadeEmprestimos < 2 && !possuiAtraso && equipamentoDisponivel)
{
    Console.WriteLine("Solicitação permitida");
}
else
{
    Console.WriteLine("Solicitação não permitida");
}

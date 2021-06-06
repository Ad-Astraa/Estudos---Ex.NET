# 🌠Software console computador de média de notas escolares

### Software sonsole simples desenvolvido como ferramenta de estudo para o [Bootcamp Take Blip FullStack Developer](https://web.digitalinnovation.one/track/take-blip-fullstack-developer) pela [Digital Innovation One](https://web.digitalinnovation.one/home), no curso de Primeiros passos com .NET + C#, com o professor [Gabriel Faraday](https://about.me/gabrielfaraday).

------

​	◼O Intuito da aplicação é simplesmente **registrar de um a 5 objetos "aluno" na memória e ser capaz de listá-los e calcular a média geral entre eles**. 

​	◼O sistema possui um menu primitivo organizado que permite que o usuário escolha uma das opções disponíveis, assim como a finalização da aplicação:

![alt text](https://github.com/Ad-Astraa/Ex.NET/blob/master/image-20210606100515809.png)

​	◼O código segue a mesma linha de desenvolvimento do professor do curso, as alterações que eu fiz foram apenas na estrutura do menu e em uma tratativa de exceções que não foi abordada no curso, pois os alunos eram avaliados em conceitos que consideravam notas de **0,00** a **10,00**, mas o sistema aceitava qualquer valor *decimal*:

```c#
if(decimal.TryParse(Console.ReadLine(), out decimal nota))
{
	if(nota <= 10)
    {
    	aluno.Nota = nota;
    }
    else
    {
         throw new ArgumentException("\n\n\nValor da nota deve ser menor ou igual a 10!\n\n\n\n");
    }
    }                      
    else
    {
         throw new ArgumentException("\n\n\nValor da nota deve ser decimal!\n\n\n\n");
    }
```


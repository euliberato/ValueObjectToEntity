# Mapeando o ValueObject Pattern para Entity

## Subtítulo: Utilizando o framework AutoMapper do .NET para o caso de estudo

Este repositório apresenta um exemplo prático de como mapear o padrão ValueObject para Entity, utilizando o framework AutoMapper do .NET. O foco principal do caso de estudo é a classe `ProductValueObject`, que define o comportamento de um objeto representando um produto, aplicável em sistemas de vendas e similares.

### Informações do Produto

O objeto de valor `ProductValueObject` é responsável por encapsular as seguintes informações relacionadas a um produto:

- **Id**
- **Name**
- **Price**
- **Description**
- **CategoryName**
- **ImageUrl**

### Estrutura da Entity

A entidade (`Entity`) é composta por três partes principais:

1. **Model**: Contém apenas o identificador (`Id`).

2. **Context**: Inclui o contexto do MySQL (`MySQLContext`) utilizado no sistema.

3. **Product**: Uma classe que estende a `BaseEntity` e possui os seguintes atributos:

    - **Name**
    - **Price**
    - **Description**
    - **CategoryName**
    - **ImageUrl**

### Configuração de Mapeamento

O componente responsável por realizar o mapeamento entre `ProductValueObject` e `Product` é denominado `MappingConfig`. Este componente é parte do arquivo `Config` e é crucial para converter instâncias de `ProductValueObject` em `Product` e vice-versa.

O resultado final é uma instância de `MapperConfiguration`, encapsulada em um objeto `mappingConfig`.

---

Este projeto serve como uma implementação didática do padrão ValueObject para Entity, utilizando o AutoMapper no contexto do .NET. Sinta-se à vontade para explorar o código-fonte e adaptar para suas necessidades específicas.

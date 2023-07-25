# SDKFingerprintReactNative

> Este projeto é um exemplo de como implementar a ferramenta Behavior Analytics SDK React Native da ClearSale.

## 💻 Pré-requisitos
Para executar esse projeto de exemplo é necessário possuir:
- Node.js >= 10.19.0
- React Native >= 0.63.2
- react-navigation/native: 5.7.3
- react-navigation/stack: 5.9.0

## 🤔 Explicação das dependências
1. @behavior-analytics-sdk/react-native-clear-sale-module (1.0.1-rc.2)
> Essa é uma dependência para o módulo de integração com a API da ClearSale. É utilizado para fazer a integração com o serviço de análise de risco da ClearSale.

2. @react-native-community/masked-view (^0.1.10)
> Essa é uma dependência para a implementação de máscaras em elementos de interface do usuário. É utilizado para aplicar máscaras em campos de formulário, por exemplo.

3. @react-navigation/native (^5.7.3)
> Essa é uma dependência para a biblioteca de navegação do React Native. É utilizada para navegar entre as telas da aplicação.

4. @react-navigation/stack (^5.9.0)
> Essa é uma dependência para a implementação de pilhas de navegação na biblioteca de navegação do React Native. É utilizada para implementar a navegação entre as telas da aplicação.

5. react (16.13.1)
> Essa é uma dependência para a biblioteca React, utilizada para criar a interface do usuário da aplicação.

6. react-native (0.63.2)
> Essa é uma dependência para a plataforma React Native, utilizada para desenvolver aplicativos móveis para iOS e Android.

7. react-native-geolocation-service (^5.0.0)
> Essa é uma dependência para a obtenção da localização do dispositivo. É utilizada para obter a localização do usuário e enviar essa informação para a API da ClearSale.

8. react-native-gesture-handler (^1.7.0)
> Essa é uma dependência para a implementação de gestos na interface do usuário. É utilizada para implementar ações como deslizar para a esquerda ou para a direita em elementos de interface.

9. react-native-safe-area-context (^3.1.4)
> Essa é uma dependência para a obtenção da área segura em dispositivos com o sistema operacional iOS. É utilizada para ajustar a interface do usuário em dispositivos com telas diferentes.

10. react-native-screens (^2.10.1)
> Essa é uma dependência para a implementação de telas na interface do usuário. É utilizada para implementar as telas da aplicação.

### DevDependencies
11. @babel/core (^7.8.4)
> Essa é uma dependência para o transpilador Babel, utilizado para converter o código JavaScript em um formato compatível com a plataforma.

12. @babel/runtime (^7.8.4)
> Essa é uma dependência para o runtime do Babel, utilizado para executar o código transpilado.

13. @react-native-community/eslint-config (^1.1.0)
> Essa é uma dependência para a configuração do ESLint, utilizado para verificar a qualidade do código.

14. babel-jest (^25.1.0)
> Essa é uma dependência para a integração do Jest com o Babel, utilizado para executar testes unitários no código.

15. eslint (^6.5.1)
> Essa é uma dependência para o ESLint, utilizado para verificar a qualidade do código.

16. jest (^25.1.0)
> Essa é uma dependência para o framework Jest, utilizado para executar testes unitários no código.

17. metro-react-native-babel-preset (^0.59.0)
> Essa é uma dependência para o preset do Babel, utilizado para converter o código JavaScript em um formato compatível com a plataforma React Native.

18. react-test-renderer (16.13.1)
> Essa é uma dependência para a biblioteca de teste React, utilizada para testar componentes React sem a necessidade de renderizá-los em um navegador ou dispositivo móvel.

###Jest
19. preset: react-native
> Essa é uma configuração para o framework Jest, utilizado para executar testes unitários no código. Essa configuração define as opções de teste para a plataforma React Native.

## ✨ Para mais detalhes
Acesse a documentação completa com informações sobre implementação da ferramenta Behavior Analytics SDK React Native em: 
[Documentação React Native](https://api.clearsale.com.br/docs/behavior-analytics/sdk/react-native/latest).

## 📫 Links Úteis
1. Informações do [Node.js] (https://nodejs.org/).
2. Informações do [React Native] (https://reactnative.dev/).

## 📝 MIT License

The MIT License (MIT)

Copyright ©  2023 ClearSale

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

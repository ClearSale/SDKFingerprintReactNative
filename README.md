# SDKFingerprintReactNative

> Este projeto é um exemplo de como implementar a ferramenta Behavior Analytics SDK React Native da ClearSale.

## 💻 Pré-requisitos
Para executar esse projeto de exemplo é necessário possuir:
- Node.js >= 10.19.0
- React Native >= 0.63.2

## 🤔 Explicação das dependências
1. @behavior-analytics-sdk/react-native-clear-sale-module (1.0.1-rc.2)
> Essa é uma dependência para o módulo de integração com a API da ClearSale. É utilizado para fazer a integração com o serviço de análise de risco da ClearSale.

2. @react-navigation/native (^5.7.3)
> Essa é uma dependência para a biblioteca de navegação do React Native. É utilizada para navegar entre as telas da aplicação.

3. @react-navigation/stack (^5.9.0)
> Essa é uma dependência para a implementação de pilhas de navegação na biblioteca de navegação do React Native. É utilizada para implementar a navegação entre as telas da aplicação.

## ℹ️ Informações adicionais
### Como limpar o projeto android:
Acesse a pasta App/android e execute o comando:
./gradlew clean

### Como gerar o .APK
Acesar a pasta App e executar o comando:
npx react-native bundle --platform android --dev false --entry-file index.js --bundle-output android/app/src/main/assets/index.android.bundle --assets-dest android/app/build/intermediates/res/merged/release/ && rm -rf android/app/src/main/res/drawable-* && rm -rf android/app/src/main/res/raw/* && cd android && ./gradlew assembleRelease && cd ..

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

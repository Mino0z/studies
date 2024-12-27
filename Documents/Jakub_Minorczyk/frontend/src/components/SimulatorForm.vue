<template>
  <div class="SimulatorForm">
    <h1>{{ msg }}</h1>

    <form @submit.prevent="submitForm" >
      <label for="command">Wybierz rozkaz:</label>
      <select id="command" v-model="formData.Command">
        <option value="MOV">MOV</option>
        <option value="XCHG">XCHG</option>
        <option value="MOV_MEM">MOV_MEM</option>
        <option value="XCHG_MEM">XCHG_MEM</option>
        <option value="PUSH">PUSH</option>
        <option value="POP">POP</option>
      </select><br>

    
      <div v-if="formData.Command === 'MOV' || formData.Command === 'XCHG'">
        <label for="register">Wybierz rejestry:</label>
        <select id="register" v-model="formData.Register">
          <option value="AX AX">AX AX</option>
          <option value="AX BX">AX BX</option>
          <option value="AX CX">AX CX</option>
          <option value="AX DX">AX DX</option>

          <option value="BX AX">BX AX</option>
          <option value="BX BX">BX BX</option>
          <option value="BX CX">BX CX</option>
          <option value="BX DX">BX DX</option>

          <option value="CX AX">CX AX</option>
          <option value="CX BX">CX BX</option>
          <option value="CX CX">CX CX</option>
          <option value="CX DX">CX DX</option>

          <option value="DX AX">DX AX</option>
          <option value="DX BX">DX BX</option>
          <option value="DX CX">DX CX</option>
          <option value="DX DX">DX DX</option>
        </select><br>

        <div v-if="formData.Register === 'AX AX'">
          <label for="ax">Wpisz AX:</label>
          <input type="text" id="ax" name="command" v-model="formData.AX"><br>
        </div>

        <div v-if="formData.Register === 'AX BX'">  
          <label for="ax">Wpisz AX:</label>
          <input type="text" id="ax" name="command" v-model="formData.AX"><br>
          
          <label for="bx">Wpisz BX:</label>
          <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        </div>  

        <div v-if="formData.Register === 'AX CX'">  
        <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>
        
        <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div>  

        <div v-if="formData.Register === 'AX DX'">  
        <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>
        
        <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        </div>  
      
        <div v-if="formData.Register === 'BX AX'">
          <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>
        </div>

        <div v-if="formData.Register === 'BX BX'">  
        <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        </div>  

        <div v-if="formData.Register === 'BX CX'">  
        <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>

        <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div> 

        <div v-if="formData.Register === 'BX DX'">  
          <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>

        <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        </div>  

        <div v-if="formData.Register === 'CX AX'">
        <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>
        </div>

        <div v-if="formData.Register === 'CX BX'">  
        
        <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>

        </div>    
        
        <div v-if="formData.Register === 'CX CX'">  
        
          <label for="cx">Wpisz CX:</label>
          <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div>  
        <div v-if="formData.Register === 'CX DX'">  
          <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        </div>  
        <div v-if="formData.Register === 'DX AX'">
          <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>
        </div>  
        <div v-if="formData.Register === 'DX BX'">  
          <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        
        <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        </div>    
        <div v-if="formData.Register === 'DX CX'">  
        
          <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div>  
        
        <div v-if="formData.Register === 'DX DX'">  
          
        <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        </div>  
      </div>
      
    
      <div v-if="formData.Command === 'MOV_MEM' || formData.Command === 'XCHG_MEM'">
        <label for="registermem">Wybierz rejestry:</label>
        <select id="registermem" v-model="formData.RegisterMem">
          <option value="AX MEM">AX MEM</option>
          <option value="BX MEM">BX MEM</option>
          <option value="CX MEM">CX MEM</option>
          <option value="DX MEM">DX MEM</option>

          <option value="MEM AX">MEM AX</option>
          <option value="MEM BX">MEM BX</option>
          <option value="MEM CX">MEM CX</option>
          <option value="MEM DX">MEM DX</option>
        </select><br>
        <label for="ax">Wybierz adresowanie:</label>
        <select v-model="formData.addressingMode">
          <option value="base">adresowanie bazowe</option>
          <option value="index">adresowanie indeksowe</option>
          <option value="indexed_base">adresowanie indeksowo-bazowe</option>
        </select>
        <div v-if="formData.addressingMode === 'base'">
          
        <div v-if="formData.RegisterMem === 'MEM AX'">
          <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>  
        </div>
        <div v-if="formData.RegisterMem === 'MEM BX'">
          <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        </div>
        <div v-if="formData.RegisterMem === 'MEM CX'">
          <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div>
        <div v-if="formData.RegisterMem === 'MEM DX'">
          <label for="dx">Wpisz DX:</label>
        <input type="text" id="Dx" name="command" v-model="formData.DX"><br>
        </div>
       
        <label for="bp">Wpisz BP:</label>
        <input type="text" id="bp" name="command" v-model="formData.BP"><br>

        <label for="offset">Wpisz Offset:</label>
        <input type="text" id="offset" name="command" v-model="formData.Offset"><br>
        
        </div>
        <div v-if="formData.addressingMode === 'index'">
          
        <div v-if="formData.RegisterMem === 'MEM AX'">
          <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>  
        </div>
        <div v-if="formData.RegisterMem === 'MEM BX'">
          <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        </div>
        <div v-if="formData.RegisterMem === 'MEM CX'">
          <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div>
        <div v-if="formData.RegisterMem === 'MEM DX'">
          <label for="dx">Wpisz DX:</label>
        <input type="text" id="Dx" name="command" v-model="formData.DX"><br>
        </div>
      
        <label for="si">Wpisz SI:</label>
        <input type="text" id="si" name="command" v-model="formData.SI"><br>

        <label for="offset">Wpisz Offset:</label>
        <input type="text" id="offset" name="command" v-model="formData.Offset"><br>
        
      </div>
      <div v-if="formData.addressingMode === 'indexed_base'">
        
        <div v-if=" formData.RegisterMem === 'MEM AX'">
          <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>  
        </div>
        <div v-if="formData.RegisterMem === 'MEM BX'">
          <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        </div>
        <div v-if="formData.RegisterMem === 'MEM CX'">
          <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div>
        <div v-if="formData.RegisterMem === 'MEM DX'">
          <label for="dx">Wpisz DX:</label>
        <input type="text" id="Dx" name="command" v-model="formData.DX"><br>
        </div>
        <label for="bp">Wpisz BP:</label>
        <input type="text" id="bp" name="command" v-model="formData.BP"><br>
    
        <label for="si">Wpisz SI:</label>
        <input type="text" id="si" name="command" v-model="formData.SI"><br>

        <label for="offset">Wpisz Offset:</label>
        <input type="text" id="offset" name="command" v-model="formData.Offset"><br>
      </div>
      </div>

      <div v-if="formData.Command === 'PUSH' || formData.Command === 'POP'">
        <label for="registerpushpop">Wybierz rejestr:</label>
        <select id="registerpushpop" v-model="formData.RegisterPushPop">
          <option value="AX">AX</option>
          <option value="BX">BX</option>
          <option value="CX">CX</option>
          <option value="DX">DX</option>

        </select><br>
        <div v-if="formData.RegisterPushPop === 'AX'">
          <label for="ax">Wpisz AX:</label>
        <input type="text" id="ax" name="command" v-model="formData.AX"><br>  
        </div>
        <div v-if="formData.RegisterPushPop === 'BX'">
          <label for="bx">Wpisz BX:</label>
        <input type="text" id="bx" name="command" v-model="formData.BX"><br>
        </div>
        <div v-if="formData.RegisterPushPop === 'CX'">
          <label for="cx">Wpisz CX:</label>
        <input type="text" id="cx" name="command" v-model="formData.CX"><br>
        </div>
        <div v-if="formData.RegisterPushPop === 'DX'">
          <label for="dx">Wpisz DX:</label>
        <input type="text" id="dx" name="command" v-model="formData.DX"><br>
        </div>
        
        <label for="sp">Wpisz SP:</label>
        <input type="text" id="sp" name="command" v-model="formData.SP"><br>
        </div>  
       
        
        <div v-if="formData.Command === 'PUSH'">
        <button @click="executeCommand('PUSH')">PUSH</button>
        </div>
        <div v-if="formData.Command === 'POP'">
        <button @click="executeCommand('POP')">POP</button>
        </div>
        <div v-if="formData.Command === 'MOV' || formData.Command === 'XCHG'|| formData.Command === 'MOV_MEM'|| formData.Command === 'XCHG_MEM'">
      <input type="submit" value="Wyślij" >
    </div>
    </form>
    <div v-if="formData.Command === 'MOV' || formData.Command === 'XCHG'">
    <div v-if="formData.Register === 'AX AX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość AX: 0x{{ response.processedValue1 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
    </div>  
      <div v-if="formData.Register === 'AX BX' || formData.Register === 'BX AX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość AX: 0x{{ response.processedValue1 }}</p>
      <p>Wartość BX: 0x{{ response.processedValue2 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
      </div>
      <div v-if="formData.Register === 'AX CX' || formData.Register === 'CX AX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość AX: 0x{{ response.processedValue1 }}</p>
      <p>Wartość CX: 0x{{ response.processedValue3 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
      </div>
   
      <div v-if="formData.Register === 'AX DX' || formData.Register === 'DX AX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość AX: 0x{{ response.processedValue1 }}</p>
      <p>Wartość DX: 0x{{ response.processedValue4 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
      </div>
      <div v-if="formData.Register === 'BX BX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość BX: 0x{{ response.processedValue2 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
    </div>  
      <div v-if="formData.Register === 'BX CX' || formData.Register === 'CX BX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość BX: 0x{{ response.processedValue2 }}</p>
      <p>Wartość CX: 0x{{ response.processedValue3 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
      </div>
      <div v-if="formData.Register === 'BX DX' || formData.Register === 'DX BX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość AX: 0x{{ response.processedValue1 }}</p>
      <p>Wartość CX: 0x{{ response.processedValue3 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
      </div>
    
      
      <div v-if="formData.Register === 'CX CX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość CX: 0x{{ response.processedValue3 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
    </div>
    <div v-if="formData.Register === 'CX DX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość CX: 0x{{ response.processedValue3 }}</p>
      <p>Wartość DX: 0x{{ response.processedValue4 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
    </div>
    <div v-if="formData.Register === 'DX DX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość DX: 0x{{ response.processedValue4 }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
    </div>
    </div>  
    <div v-if="formData.Command === 'MOV_MEM' || formData.Command === 'XCHG_MEM'">
    <div v-if="formData.RegisterMem === 'AX MEM' || formData.RegisterMem === 'MEM AX'">
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość AX: 0x{{ response.processedValue1 }}</p>
      <p><strong>adres pamięci:</strong> 0x{{ response.calculatedAddress }}</p>
      <p><strong>wartość adresu pamięci:</strong> 0x{{ response.calculatedValue }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>  
      </div>
      <div v-if="formData.RegisterMem === 'BX MEM' || formData.RegisterMem === 'MEM BX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość BX: 0x{{ response.processedValue2 }}</p>
      <p><strong>adres pamięci:</strong> 0x{{ response.calculatedAddress }}</p>
      <p><strong>wartość adresu pamięci:</strong> 0x{{ response.calculatedValue }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
    </div>  
    <div v-if="formData.RegisterMem === 'CX MEM' || formData.RegisterMem === 'MEM CX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość CX: 0x{{ response.processedValue3 }}</p>
      <p><strong>adres pamięci:</strong> 0x{{ response.calculatedAddress }}</p>
      <p><strong>wartość adresu pamięci:</strong> 0x{{ response.calculatedValue }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
    </div>
    <div v-if="formData.RegisterMem === 'DX MEM' || formData.RegisterMem === 'MEM DX'" >
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość DX: 0x{{ response.processedValue4 }}</p>
      <p><strong>adres pamięci:</strong> 0x{{ response.calculatedAddress }}</p>
      <p><strong>wartość adresu pamięci:</strong> 0x{{ response.calculatedValue }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
    </div>
      </div>
    </div>
    <div v-if="formData.Command === 'PUSH' || formData.Command === 'POP'">
      <div v-if="formData.RegisterPushPop === 'AX'">
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość AX: 0x{{ response.processedValue1 }}</p>
      <p>Wartości na stosie: {{ stack.join(", ") }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
      </div>
    </div>
    <div v-if="formData.RegisterPushPop === 'BX'">
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość BX: 0x{{ response.processedValue2 }}</p>
      <p>Wartości na stosie: {{ stack.join(", ") }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
      </div>
    </div>
    <div v-if="formData.RegisterPushPop === 'CX'">
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość CX: 0x{{ response.processedValue3 }}</p>
      <p>Wartości na stosie: {{ stack.join(", ") }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
      </div>
    </div>
    <div v-if="formData.RegisterPushPop === 'DX'">
      <div v-if="response">
      <h3>Przetworzone dane:</h3>
      <p>Wartość DX: 0x{{ response.processedValue4 }}</p>
      <p>Wartości na stosie: {{ stack.join(", ") }}</p>
      <p>Metoda przetwarzania: {{ response.processMethod }}</p>
      </div>
    </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  data() {
    return {
      msg: "Symulator rozkazów procesora",
      formData: {
        AX: "0x0000",
        BX: "0x0000",
        CX: "0x0000",
        DX: "0x0000",
        BP: "0x0000",
        DI: "0x0000",
        SI: "0x0000",
        SP: "0x0000",
        Offset: "0x0000",
        Command: "MOV",
        Register: "AX AX",
        RegisterMem: "AX MEM",
        RegisterPushPop: "AX",
        baseRegister: "BP",
        indexRegister: "SI",
        addressingMode: "base",
      },
      stack: [],
      response: null,
      submitted: false,
    };
  },
  methods: {
    async submitForm() {
      const formData = {
        AX: parseInt(this.formData.AX, 16),  
        BX: parseInt(this.formData.BX, 16),
        CX: parseInt(this.formData.CX, 16), 
        DX: parseInt(this.formData.DX, 16),
        BP: parseInt(this.formData.BP, 16),
        DI: parseInt(this.formData.DI, 16),
        SI: parseInt(this.formData.SI, 16),
        SP: parseInt(this.formData.SP, 16),
        Offset: parseInt(this.formData.Offset, 16),
        Command: this.formData.Command,
        Register: this.formData.Register,
        RegisterMem: this.formData.RegisterMem,
        RegisterPushPop: this.formData.RegisterPushPop,
        addressingMode : this.formData.addressingMode,
        baseRegister: this.formData.baseRegister,
        indexRegister: this.formData.indexRegister,
      };
      
      try{
      const res = await axios.post("http://localhost:5041/api/cpu", formData);
      console.log(res.data) ;
      console.log("Response z API:", this.response);
      console.log("Response z API:", res.data.memory , res.data.memoryValue2, res.data.calculatedAddress);
console.log("Processed values: ", res.data.processedValue1, res.data.processedValue2, res.data.processedValue3, res.data.processedValue4, res.data.processMethod);

      this.response = res.data;
      
    }
      catch (error) {
        console.error(error);
      }
    },
    executeCommand() {
      if (this.formData.Command === "PUSH") {
          this.pushToStack(); 
        }

        if (this.formData.Command === "POP") {
          this.popFromStack(); 
        }
      },
    pushToStack() {
      const registerValue = this.formData[this.formData.RegisterPushPop];
      if (this.formData.SP > 0) {
        this.stack.push(registerValue); 
        this.formData.SP--; 
      } else {
        alert("Brak miejsca na stosie!");
      }
    },

    popFromStack() {
      if (this.stack.length > 0) {
        const poppedValue = this.stack.pop(); 
        this.formData[this.formData.RegisterPushPop] = poppedValue; 
        this.formData.SP++; 
      } else {
        alert("Stos jest pusty!");
      }
    },
  },
};
</script>

<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>

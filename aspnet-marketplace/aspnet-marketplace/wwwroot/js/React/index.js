import React, { useState } from "react";
import ReactDOM from "react-dom";

const HelloWorld = () => {
  const [count, setCount] = useState(1);
  const increment = () => {
    setCount(count + 1);
  };
  return (
    <div>
      <h1>Current number: {count}</h1>
      <button onClick={increment}>Increment count</button>
    </div>
  );
};

ReactDOM.render(<HelloWorld />, document.getElementById("root"));

import React from "react";

const ResultsList = ({ results }) => {
  return (
    <div>
      <ul>
        {results.map((result) => (
          <li key={result.id}>{result.volumeInfo.title}</li>
        ))}
      </ul>
    </div>
  );
};

export default ResultsList;

import React from "react";

const ResultsList = ({ results }) => {
  return (
    <div>
      <ul className="resultslist">
        {results.map((result) => (
          <li key={result.id}>{result.volumeInfo.title}</li>
        ))}
      </ul>
    </div>
  );
};

export default ResultsList;

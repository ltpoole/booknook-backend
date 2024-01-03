import React from "react";
import { Link } from "react-router-dom";

const ResultsList = ({ results }) => {
  return (
    <div>
      <ul className="resultslist">
        {results.map((result) => (
          <Link to={`/book/${result.id}/`}>
            <li key={result.id}>{result.volumeInfo.title}</li>
          </Link>
        ))}
      </ul>
    </div>
  );
};

export default ResultsList;

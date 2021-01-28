export interface IBasket {
    id: string;
    items: Item[];
}


export interface Item {
  id: number;
  productName: string;
  price: number;
  quantity: number;
  pictureUrl: string;
  brand: string;
  type: string;
}


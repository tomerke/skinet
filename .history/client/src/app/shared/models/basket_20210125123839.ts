export interface IBasket {
    id: string;
    items: Item[];
}

export interface IItem {
  id: number;
  productName: string;
  price: number;
  quantity: number;
  pictureUrl: string;
  brand: string;
  type: string;
}

